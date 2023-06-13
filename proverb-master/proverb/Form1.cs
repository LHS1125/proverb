namespace proverb
{
    public partial class Form1 : Form
    {
        private int level;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLevel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectLevel(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelectLevel(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SelectLevel(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SelectLevel(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SelectLevel(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SelectLevel(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SelectLevel(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SelectLevel(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SelectLevel(9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            SelectLevel(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SelectLevel(11);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            SelectLevel(12);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            SelectLevel(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SelectLevel(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SelectLevel(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SelectLevel(16);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            SelectLevel(17);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            SelectLevel(18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SelectLevel(19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SelectLevel(20);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            SelectLevel(21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SelectLevel(22);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            SelectLevel(23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SelectLevel(24);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            SelectLevel(25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            SelectLevel(26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SelectLevel(27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SelectLevel(28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            SelectLevel(29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            SelectLevel(30);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// 파일 생성 메서드
        /// </summary>

        private void CreateFile()
        {
            string path = @".\level.txt";
            bool fileExist = File.Exists(path);

            if (!fileExist)
            {
                using (File.Create(path))
                {

                }
                SaveLevel();
            }
            else
            {
                MessageBox.Show("이미 파일이 존재합니다.");
            }
        }

        /// <summary>
        /// 레벨 불러오기 메서드
        /// </summary>
        private void LoadLevel()
        {
            string path = @".\level.txt";
            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                StreamReader reader = new StreamReader(path);

                string result = "";
                result = reader.ReadToEnd();

                level = Int32.Parse(result);
                reader.Close();
            }
            else level = 0;

            CheckLevel();
        }

        /// <summary>
        /// 레벨 저장 메서드
        /// </summary>
        private void SaveLevel()
        {
            string path = @".\level.txt";
            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                File.WriteAllText(path, level.ToString());
            }
            else
            {
                CreateFile();
            }
        }

        /// <summary>
        /// 레벨 체크 메서드
        /// 도전 가능한 레벨 활성화 처리
        /// </summary>
        private void CheckLevel()
        {
            for (int i = 1; i <= 30; i++)
            {
                Controls["button" + i].Enabled = i <= (level + 1);
            }
        }

        /// <summary>
        /// 레벨 선택 메서드
        /// </summary>
        private void SelectLevel(int selectLevel)
        {
            Form2 frm = new Form2(this, selectLevel);
            frm.Show();
            this.Hide();
        }

        /// <summary>
        /// 해당레벨 레벨 클리어 메서드
        /// </summary>
        /// <param name="clearLevel"></param>
        public void ClearLevel(int clearLevel)
        {
            if (clearLevel > level)
            {
                level = clearLevel;
                SaveLevel();
                CheckLevel();
            }
        }
    }
}