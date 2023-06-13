using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proverb
{
    /// <summary>
    /// 스테이지 화면
    /// </summary>
    public partial class Form2 : Form
    {
        private int selectedLevel;
        private Form1 frm1;
        private string[] quiz;
        private string[] result;

        /// <summary>
        /// 생성자 함수
        /// </summary>
        /// <param name="frm1"></param>
        /// <param name="selectedLevel"></param>
        public Form2(Form1 frm1, int selectedLevel = 1)
        {
            InitializeComponent();
            this.frm1 = frm1;
            this.selectedLevel = selectedLevel;
            this.Text = selectedLevel + "스테이지";
        }

        /// <summary>
        /// 폼 열림 이벤트 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            string[] quiz = {
                "□□는 게 편이라",
                "□에 걸면 □□이, □에 걸면 □□이",
                "□ 놓고 □□□도 모른다",
                "낮말은 □가 듣고 밤말은 □가 듣는다",
                "□□ 줄 것은 없어도 □□맞을 것은 있다",
                "□□ 먹다 □ 빠진다",
                "□□ 하늘에 □□□",
                "믿는 □□에 □□ 찍힌다",
                "범도 개에게 □□ 때가 있다",
                "보기 좋은 떡이 □□도 좋다",

                "□□□도 맞들면 낫다",
                "□□도 단김에 빼랬다",
                "□□이 많으면 배가 □으로 올라간다",
                "어물전 망신은 □□□가 시킨다",
                "열 길 □ 속은 알아도 한 길 □□ 속은 모른다",
                "열 번 찍어 아니 넘어가는 □□ 없다",
                "오르지 못할 나무는 □□□□도 말아라",
                "우물에 가서 □□ 찾는다",
                "□□□도 나무에서 떨어진다",
                "윗물이 □□야 아랫물도 □다",
                "□□ 보고 놀란 가슴 □□□ 보고 놀란다",

                "□□ 고추가 더 맵다",
                "좋은 약은 입에 □□",
                "□□□에도 볕 들 날이 있다",
                "□□□도 밟으면 꿈틀한다",
                "천 리 길도 □ □□부터",
                "칼로 □ □□",
                "□ 심은 데 □ 나고 □ 심은 데 □ 난다",
                "□□ 모아 태산",
                "□□ 없는 무덤 없다",
                "하늘의 □ 따기",
            };
            this.quiz = quiz;
            string[] result = {
                "가재는 게 편이라",
                "귀에 걸면 귀걸이, 코에 걸면 코걸이",
                "낫 놓고 기역자도 모른다",
                "낮말은 새가 듣고 밤말은 쥐가 듣는다",
                "동생 줄 것은 없어도 도적맞을 것은 있다",
                "두부 먹다 이 빠진다",
                "마른 하늘에 날벼락",
                "믿는 도끼에 발등 찍힌다",
                "범도 개에게 물릴 때가 있다",
                "보기 좋은 떡이 먹기도 좋다",

                "백지장도 맞들면 낫다",
                "쇠뿔도 단김에 빼랬다",
                "사공이 많으면 배가 산으로 올라간다",
                "어물전 망신은 꼴뚜기가 시킨다",
                "열 길 물 속은 알아도 한 길 사람 속은 모른다",
                "열 번 찍어 아니 넘어가는 나무 없다",
                "오르지 못할 나무는 쳐다보지도 말아라",
                "우물에 가서 숭늉 찾는다",
                "원숭이도 나무에서 떨어진다",
                "윗물이 맑아야 아랫물도 맑다",
                "자라 보고 놀란 가슴 솥뚜껑 보고 놀란다",

                "작은 고추가 더 맵다",
                "좋은 약은 입에 쓰다",
                "쥐구멍에도 볕 들 날이 있다",
                "지렁이도 밟으면 꿈틀한다",
                "천 리 길도 한 걸음부터",
                "칼로 물 베기",
                "콩 심은 데 콩 나고 팥 심은 데 팥 난다",
                "티끌 모아 태산",
                "핑계 없는 무덤 없다",
                "하늘의 별 따기",
            };
            this.result = result;

            Quiz.Text = quiz[selectedLevel - 1];
            this.ActiveControl = textBox1;
        }

        /// <summary>
        /// 폼 닫힘 이벤트 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }

        /// <summary>
        /// 입력버튼 클릭 이벤트 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CheckResult(textBox1.Text);
        }

        /// <summary>
        /// 텍스트박스 키 입력 이벤트 함수(엔터 체크)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckResult(textBox1.Text);
                textBox1.Text = "";
            }

        }


        /// <summary>
        /// 정답 체크 메서드
        /// </summary>
        /// <param name="answered"></param>        
        private void CheckResult(string answered)
        {
            string rslt = result[selectedLevel - 1].Replace(" ", "").Replace(",", "");
            answered = answered.Replace(" ", "").Replace(",", "").Replace(".", "");
            if (rslt == answered)
            {
                MessageBox.Show("정답입니다!", "결과");
                frm1.ClearLevel(selectedLevel);
                this.Close();
            }
            else
            {
                MessageBox.Show("실패, 다시 한번 생각해 주세요.", "결과");
            }
        }
    }
}
