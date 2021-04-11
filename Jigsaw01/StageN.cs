using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jigsaw01
{
    public partial class form_StageN : Form
    {
        const int WIDTH = 80;
        const int HEIGHT = 80;
        string username;
        int stage, BaseX, BaseY, hint;
        PictureBox[,] img;
        int[,,] tempLocal;
        int[,,] defultLocal;

        public form_StageN(string Username, int Stage)
        {
            this.username = Username;
            this.stage = Stage;
            InitializeComponent();
        }

        

        private void form_StageN_Load(object sender, EventArgs e)
        {
            this.img = new PictureBox[5, 5] {
                { img00, img01, img02, img03, img04 },
                { img10, img11, img12, img13, img14 },
                { img20, img21, img22, img23, img24 },
                { img30, img31, img32, img33, img34 },
                { img40, img41, img42, img43, img44 }
            };
            this.defultLocal = new int[5, 5, 2];
            this.tempLocal = new int[5, 5, 2];
            for (int i = 0; i < 5; ++i){
                for (int j = 0; j < 5; ++j){
                    for (int k = 0; k < 2; ++k) {
                        ControlExtension.Draggable(img[i, j], true);
                        if (k == 0){
                            this.tempLocal[i, j, 0] = this.img[i, j].Location.X;
                        }
                        else {
                            this.tempLocal[i, j, 1] = this.img[i, j].Location.Y;
                        }
                    }
                }
            }
            this.Text = this.username + this.stage.ToString();
            this.BaseX = imgBase.Location.X;
            this.BaseY = imgBase.Location.Y;
            this.hint = 3;
            timer1.Start();
        }

        private (int,int) inAnyBlock(int X,int Y) {
            for (int y = 0; y < 5; ++y) {
                for (int x = 0; x < 5; ++x) {
                    if ((X >= BaseX + WIDTH * x && X <= BaseX + WIDTH * x + WIDTH) && (Y >= BaseY + HEIGHT * y && Y <= BaseY + HEIGHT * y + HEIGHT)) {
                        return (x,y);
                    }
                }
            }
            return (-1, -1);
        }

        

        private void DragProgress(int j,int i) {

            int imgXPosit = this.img[j, i].Location.X + this.img[j, i].Width / 2;
            int imgYPosit = this.img[j, i].Location.Y + this.img[j, i].Height / 2;
            var position = inAnyBlock(imgXPosit, imgYPosit);
            if (position.Item1 != -1)
            {
                int newX = BaseX + WIDTH * position.Item1;
                int newY = BaseY + HEIGHT * position.Item2;
                var check = isAlreadyPlace(newX, newY);
                if (!check.Item1) {
                    img[j, i].SetBounds(newX, newY, WIDTH, HEIGHT);
                }
                else {
                    //img[check.Item2, check.Item3].SetBounds();
                }
            }
            
        }

        private (bool, int, int) isAlreadyPlace(int X, int Y) {
            for (int i = 0; i < 5; ++i){
                for (int j = 0; j < 5; ++j){
                    if (X == this.img[i,j].Location.X && Y == this.img[i, j].Location.Y){
                        return (true, i, j);
                    }
                }
            } return (false, -1, -1);
        }

        /*private void BlockPositionRandom(){
            for (int i = 0; i < 5; ++i){
                for (int j = 0; j < 5; ++j){
                    ControlExtension.Draggable(img[i, j], true);
                    this.defultLocal[i,j] = this.tempLocal[]
                }
            }
        }*/

        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++second;
            txt_stageTimer.Text = second.ToString();
        }

        private void btn_stageHint_Click(object sender, EventArgs e)
        {
            txt_stageHint.Text = Hint().ToString();
        }

        private int Hint() {
            if (!(this.hint <= 0)){
                MessageBox.Show("Hint!");
                this.hint--;
            }
            else {
                MessageBox.Show("No Hint Left :(");
            }
            return this.hint;
        }



        // Img0N + =========================================
        private void img00_Click(object sender, EventArgs e)
        {
            DragProgress(0, 0);
        }
        private void img01_Click(object sender, EventArgs e)
        {
            DragProgress(0, 1);
        }

        private void img02_Click(object sender, EventArgs e)
        {
            DragProgress(0, 2);
        }

        private void img03_Click(object sender, EventArgs e)
        {
            DragProgress(0, 3);
        }

        private void img04_Click(object sender, EventArgs e)
        {
            DragProgress(0, 4);
        }

        // Img1N + =========================================
        private void img14_Click(object sender, EventArgs e)
        {
            DragProgress(1, 4);
        }

        private void img13_Click(object sender, EventArgs e)
        {
            DragProgress(1, 3);
        }

        private void img12_Click(object sender, EventArgs e)
        {
            DragProgress(1, 2);
        }

        private void img11_Click(object sender, EventArgs e)
        {
            DragProgress(1, 4);
        }

        private void img10_Click(object sender, EventArgs e)
        {
            DragProgress(1, 0);
        }

        // Img2N + =========================================
        private void img24_Click(object sender, EventArgs e)
        {
            DragProgress(2, 4);
        }

        private void img23_Click(object sender, EventArgs e)
        {
            DragProgress(2, 3);
        }

        private void img22_Click(object sender, EventArgs e)
        {
            DragProgress(2, 2);
        }

        private void img21_Click(object sender, EventArgs e)
        {
            DragProgress(2, 1);
        }

        private void img20_Click(object sender, EventArgs e)
        {
            DragProgress(2, 0);
        }

        // Img3N + =========================================
        private void img34_Click(object sender, EventArgs e)
        {
            DragProgress(3, 4);
        }

        private void img33_Click(object sender, EventArgs e)
        {
            DragProgress(3, 3);
        }

        private void img32_Click(object sender, EventArgs e)
        {
            DragProgress(3, 2);
        }

        private void img31_Click(object sender, EventArgs e)
        {
            DragProgress(3, 1);
        }

        private void img30_Click(object sender, EventArgs e)
        {
            DragProgress(3, 0);
        }

        // Img4N + =========================================
        private void img44_Click(object sender, EventArgs e)
        {
            DragProgress(4, 4);
        }

        private void img43_Click(object sender, EventArgs e)
        {
            DragProgress(4, 3);
        }

        private void img42_Click(object sender, EventArgs e)
        {
            DragProgress(4, 2);
        }

        private void img41_Click(object sender, EventArgs e)
        {
            DragProgress(4, 1);
        }

        private void img40_Click(object sender, EventArgs e)
        {
            DragProgress(4, 0);
        }
    }
}
