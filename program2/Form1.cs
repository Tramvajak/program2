using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Start.Enabled = false;
        }

        string path;


        private string Text = null;


        private void btn_SelectFile_Click(object sender, EventArgs e) // диалог выбора файла
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                text_FilePath.Text = path;
                using (StreamReader stream = new StreamReader(path))
                {
                    Text = stream.ReadToEnd();
                }
                btn_Start.Enabled = true;
            }
        }
        CipherMode[] Modes = { CipherMode.ECB,CipherMode.CBC,CipherMode.CFB,CipherMode.OFB,CipherMode.CTS};
        PaddingMode[] Paddings = { PaddingMode.PKCS7, PaddingMode.Zeros, PaddingMode.None };
        private void btn_Start_Click(object sender, EventArgs e)
        {

            Start(_DES);
            Start(_TripleDES);
            Start(_Rijndael);
            Start(_RC2);


            //Encrypt(_Rijndael, key, iv, CipherMode.OFB, PaddingMode.Zeros);
        }

        private void Start(string alg) // перебор всех mode and padding с таймером выполнения, шифрофка, дешифровка и внесение результаты в таблицу
        {
            for (int i = 0; i < Modes.Length; i++)
            {
                for (int j = 0; j < Paddings.Length; j++)
                {
                    try
                    {
                        byte[] key = GenKey(alg);
                        byte[] iv = GenIV(alg);

                        TimeSpan time = Timer(() => Encrypt(alg, key, iv, Modes[i], Paddings[j]));
                        dataGridView1.Rows.Add(alg, Modes[i].ToString(), Paddings[j].ToString(),"Encrypt", time.TotalMilliseconds.ToString());

                        time = Timer(() => Decrypt(alg, key, iv, Modes[i], Paddings[j]));
                        dataGridView1.Rows.Add(alg, Modes[i].ToString(), Paddings[j].ToString(),"Decrypt", time.TotalMilliseconds.ToString());

                    }
                    catch (Exception)
                    {
                        dataGridView1.Rows.Add(alg, Modes[i].ToString(), Paddings[j].ToString(),"", "Err");
                    }
                    
                }
            }
        }

        private void Encrypt(string algorithm, byte[] Key, byte[] IV, CipherMode Mode, PaddingMode Padding) // шифрование
        {
            SymmetricAlgorithm sa = CreateSymmetricAlgorithm(algorithm);

            sa.Key = Key;
            sa.IV = IV;

            sa.Mode = Mode;
            sa.Padding = Padding;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(),CryptoStreamMode.Write);

            byte[] plainbytes = Encoding.UTF8.GetBytes(Text);
            cs.Write(plainbytes, 0, plainbytes.Length);
            cs.Close();
            byte[] cipherbytes = ms.ToArray();
            ms.Close();

            Debug.WriteLine("ENCRYPT ALGORITM:" + algorithm + "; MODE:" + Mode.ToString() + "; PADDING:" + Padding.ToString());
            DebugHash(cipherbytes);
        }
        private void Decrypt(string algorithm, byte[] Key, byte[] IV, CipherMode Mode, PaddingMode Padding) // дешифрование
        {
            SymmetricAlgorithm sa = CreateSymmetricAlgorithm(algorithm);

            sa.Key = Key;
            sa.IV = IV;

            sa.Mode = Mode;
            sa.Padding = Padding;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] plainbytes = Encoding.UTF8.GetBytes(Text);
            cs.Write(plainbytes, 0, plainbytes.Length);
            cs.Close();
            byte[] cipherbytes = ms.ToArray();
            ms.Close();

            Debug.WriteLine("DECRYPT ALGORITM:" + algorithm + "; MODE:" + Mode.ToString() + "; PADDING:" + Padding.ToString());
            DebugHash(cipherbytes);
        }

        private byte[] GenIV(string alg) // новый рандомный вектор
        {
            //Generate new random IV
            SymmetricAlgorithm sa = CreateSymmetricAlgorithm(alg);
            sa.GenerateIV();
            return sa.IV;
            
        }
        private byte[] GenKey(string alg) // новый рандомный ключ
        {
            //Generate new random IV
            SymmetricAlgorithm sa = CreateSymmetricAlgorithm(alg);
            sa.GenerateKey();
            return sa.Key;
        }





        SymmetricAlgorithm CreateSymmetricAlgorithm(string algoritm) // выбор алгоритма шифрование
        {
            //create new instance of symmetric algorithm
            if (algoritm == _RC2)
                return RC2.Create();
            if (algoritm == _Rijndael)
                return Rijndael.Create();
            if (algoritm == _DES)
                return DES.Create();
            if (algoritm == _TripleDES)
                return TripleDES.Create();
            return null;
        }
        private const string _RC2 = "RC2";
        private const string _Rijndael = "Rijndael";
        private const string _DES = "DES";
        private const string _TripleDES = "TripleDES";

        private TimeSpan Timer(Action action) // таймер выполнения
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            action();
            watch.Stop();
            return watch.Elapsed;
        }
        /// <summary>
        /// Debug Write Line array Hash
        /// </summary>
        /// <param name="hash">Hash</param>
        private void DebugHash(byte[] hash) 
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(String.Format("{0,2:X2} ", hash[i]));
            Debug.WriteLine(sb.ToString());
        }

    }
}
