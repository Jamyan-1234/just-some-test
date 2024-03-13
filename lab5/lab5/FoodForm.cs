using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5

{
    public partial class FoodForm : Form
    {

        public FoodForm()
        {
            InitializeComponent();
        }
        double food1_half_price = 22;                  //FOOD PRICE
        double food1_full_price = 31;

        double food2_half_price = 17;
        double food2_full_price = 24;

        double food3_half_price = 14;
        double food3_full_price = 28;

        double food4_half_price = 17;
        double food4_full_price = 24;                 //FOOD PRICE






        double zuush1_half_price = 5;                  //ZUUSH PRICE
        double zuush1_full_price = 10;

        double zuush2_half_price = 6;
        double zuush2_full_price = 12;

        double zuush3_half_price = 7;
        double zuush3_full_price = 14;                 //ZUUSH PRICE










        double total_price;
        double total_item;

        double total_food;
        double total_zuush;

        double discount1;
        double discount2;
        double discount3;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }










        ///////////////////////////////////////////////////////////////////////////////
        private void checkBox1_CheckedChanged(object sender, EventArgs e)             //
        {                                                                             //
            if (food1halfch.Checked == true)                      //Food1Halfcheckbox
            {
                food1halfq.Enabled = true;
                food1halfq.Text = "0";
            }                                                      //Food1Halfcheckbox
            else
            {
                food1halfq.Enabled = false;                         //Food1Halfcheckbox                   //
                food1halfq.Text = "0";
            }                                                                         //
        }///////////////////////////////////////////////////////////////////////////////






        private void FoodForm_Load(object sender, EventArgs e)
        {
            food1halfch.Enabled = false;                      //FOOD
            food1halfq.Enabled = false;        //
            food1halfq.Text = "0";
            food1fullch.Enabled = false;//
            food1fullq.Enabled = false;
            food1fullq.Text = "0";
            //MAIN LOGIC//
            //
            food2halfch.Enabled = false;//
            food2halfq.Enabled = false;
            food2fullch.Enabled = false;//
            food2fullq.Enabled = false;
            food2halfq.Text = "0";
            food2fullq.Text = "0";

            //
            food3halfch.Enabled = false;//
            food3halfq.Enabled = false;
            food3fullch.Enabled = false;
            food3fullq.Enabled = false;
            food3halfq.Text = "0";
            food3fullq.Text = "0";


            food4halfch.Enabled = false;
            food4halfq.Enabled = false;
            food4fullch.Enabled = false;
            food4fullq.Enabled = false;                       //FOOD
            food4halfq.Text = "0";
            food4fullq.Text = "0";








            zuush1halfch.Enabled = false;                     //ZUUSH
            zuush1halfq.Enabled = false;        //
            zuush1fullch.Enabled = false;//
            zuush1fullq.Enabled = false;
            zuush1halfq.Text = "0";
            zuush1fullq.Text = "0";

            zuush2halfch.Enabled = false;//
            zuush2halfq.Enabled = false;
            zuush2fullch.Enabled = false;//
            zuush2fullq.Enabled = false;
            zuush2halfq.Text = "0";
            zuush2fullq.Text = "0";


            zuush3halfch.Enabled = false;
            zuush3halfq.Enabled = false;
            zuush3fullch.Enabled = false;
            zuush3fullq.Enabled = false;
            zuush3halfq.Text = "0";
            zuush3fullq.Text = "0";                         //ZUUSH











        }









        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox18_CheckedChanged(object sender, EventArgs e)                             //
        {
            if (food4.Checked == true)                               //FOOD 4 CHECKBOX                 //
            {
                food4halfch.Enabled = true;
                food4fullch.Enabled = true;


            }
            else
            {
                food4halfch.Enabled = false;
                food4halfq.Enabled = false;                      //FOOD 4 CHECKBOX
                food4fullch.Enabled = false;
                food4fullq.Enabled = false;

                food4halfch.Checked = false;
                food4halfq.Text = "0";
                food4fullch.Checked = false;
                food4fullq.Text = "0";                            //FOOD 4 CHECKBOX
                                                                  //
            }
        }/////////////////////////////////////////////////////////////////////////////////////////////////






        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush2.Checked == true)                               //ZUUSH 2 CHECKBOX 
            {
                zuush2halfch.Enabled = true;
                zuush2halfq.Enabled = false;
                zuush2fullch.Enabled = true;


            }
            else
            {
                zuush2halfch.Enabled = false;
                zuush2halfq.Enabled = false;                      //ZUUSH 2 CHECKBOX
                zuush2fullch.Enabled = false;
                zuush2fullq.Enabled = false;

                zuush2halfch.Checked = false;
                zuush2halfq.Text = "";
                zuush2fullch.Checked = false;
                zuush2fullq.Text = "";                            //ZUUSH 2 CHECKBOX
                                                                  //
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////










        /////////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush3.Checked == true)                               //ZUUSH 3 CHECKBOX 
            {
                zuush3halfch.Enabled = true;
                zuush3halfq.Enabled = false;
                zuush3fullch.Enabled = true;


            }
            else
            {
                zuush3halfch.Enabled = false;
                zuush3halfq.Enabled = false;                      //ZUUSH 3 CHECKBOX
                zuush3fullch.Enabled = false;
                zuush3fullq.Enabled = false;

                zuush3halfch.Checked = false;
                zuush3halfq.Text = "0";
                zuush3fullch.Checked = false;
                zuush3fullq.Text = "0";                            //ZUUSH 3 CHECKBOX
                                                                   //
            }
        }


















        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox15_CheckedChanged(object sender, EventArgs e)                             //
        {
            if (food1.Checked == true)                               //FOOD 1 CHECKBOX                 //
            {
                food1halfch.Enabled = true;
                food1fullch.Enabled = true;


            }
            else
            {
                food1halfch.Enabled = false;
                food1halfq.Enabled = false;                      //FOOD 1 CHECKBOX
                food1fullch.Enabled = false;
                food1fullq.Enabled = false;

                food1halfch.Checked = false;
                food1halfq.Text = "0";
                food1fullch.Checked = false;
                food1fullq.Text = "0";                            //FOOD 1 CHECKBOX

            }

            //                                                                                          //
        }/////////////////////////////////////////////////////////////////////////////////////////////








        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void food2_CheckedChanged(object sender, EventArgs e)                                   //
        {//
            if (food2.Checked == true)                               //FOOD 2 CHECKBOX                 //
            {
                food2halfch.Enabled = true;
                food2halfq.Enabled = false;
                food2fullch.Enabled = true;


            }
            else
            {
                food2halfch.Enabled = false;
                food2halfq.Enabled = false;                      //FOOD 2 CHECKBOX
                food2fullch.Enabled = false;
                food2fullq.Enabled = false;

                food2halfch.Checked = false;
                food2halfq.Text = "0";
                food2fullch.Checked = false;
                food2fullq.Text = "0";                            //FOOD 2 CHECKBOX
                                                                  //
            }                                                                                           //
        }/////////////////////////////////////////////////////////////////////////////////////////////////









        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void food3_CheckedChanged(object sender, EventArgs e)                                  //
        {
            if (food3.Checked == true)                               //FOOD 3 CHECKBOX                 //
            {
                food3halfch.Enabled = true;
                food3fullch.Enabled = true;


            }
            else
            {
                food3halfch.Enabled = false;
                food3halfq.Enabled = false;                      //FOOD 3 CHECKBOX
                food3fullch.Enabled = false;
                food3fullq.Enabled = false;

                food3halfch.Checked = false;
                food3halfq.Text = "0";
                food3fullch.Checked = false;
                food3fullq.Text = "0";                            //FOOD 3 CHECKBOX
                                                                  //
            }                                                                                            //
        }//////////////////////////////////////////////////////////////////////////////////////////////////





        private void food1fullq_TextChanged(object sender, EventArgs e)
        {

        }




        ///////////////////////////////////////////////////////////////////////
        ///////////
        private void food1fullch_CheckedChanged_1(object sender, EventArgs e)         //
        {
            if (food1fullch.Checked == true)                     //FOOD 1 FULL CHECKBOX
            {
                food1fullq.Enabled = true;
                food1fullq.Text = "0";
            }                                                    //FOOD 1 FULL CHECKBOX
            else
            {
                food1fullq.Enabled = false;                 //FOOD 1 FULL CHECKBOX
                food1fullq.Text = "0";
            }                                                                          //
        }//////////////////////////////////////////////////////////////////////////////







        private void food1halfq_TextChanged(object sender, EventArgs e)
        {

        }



        ///////////////////////////////////////////////////////////////////////////////////////////
        private void food2halfch_CheckedChanged_1(object sender, EventArgs e)                    //
        {
            if (food2halfch.Checked == true)                      //Food2Halfcheckbox
            {
                food2halfq.Enabled = true;
                food2halfq.Text = "0";
            }                                                      //Food2Halfcheckbox
            else
            {
                food2halfq.Enabled = false;                         //Food2Halfcheckbox
                food2halfq.Text = "0";
            }                                                                                    //
        }///////////////////////////////////////////////////////////////////////////////////////////





        //}///////////////////////////////////////////////////////////////////////////////////////////
        private void food2fullch_CheckedChanged(object sender, EventArgs e)                         //
        {                                                                                            //
            if (food2fullch.Checked == true)                     //FOOD 2 FULL CHECKBOX
            {
                food2fullq.Enabled = true;
                food2fullq.Text = "0";
            }                                                    //FOOD 2 FULL CHECKBOX
            else
            {
                food2fullq.Enabled = false;
                food2fullq.Text = "0";                           //FOOD 2 FULL CHECKBOX
            }                                                                                         //
        }                                                                                            //
        //}///////////////////////////////////////////////////////////////////////////////////////////




        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void food3halfch_CheckedChanged(object sender, EventArgs e)                              //
        {                                                                                                 //
            if (food3halfch.Checked == true)                      //Food3Halfcheckbox
            {
                food3halfq.Enabled = true;
                food3halfq.Text = "0";

            }                                                      //Food3Halfcheckbox
            else
            {
                food3halfq.Enabled = false;                         //Food3Halfcheckbox                   //
                food3fullq.Text = "0";
            }
        }///////////////////////////////////////////////////////////////////////////////////////////////////  




        //
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void food3fullch_CheckedChanged(object sender, EventArgs e)                               //
        {
            if (food3fullch.Checked == true)                     //FOOD 3 FULL CHECKBOX
            {
                food3fullq.Enabled = true;
                food3fullq.Text = "0";
            }                                                    //FOOD 3 FULL CHECKBOX
            else
            {
                food3fullq.Enabled = false;
                //FOOD 3 FULL CHECKBOX
                food3fullq.Text = "0";
            }
        }                                                                                                 //
                                                                                                          ///////////////////////////////////////////////////////////////////////////////////////////////////








        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void food4halfch_CheckedChanged_1(object sender, EventArgs e)                             //
        {
            if (food4halfch.Checked == true)                      //Food4Halfcheckbox
            {
                food4halfq.Enabled = true;
                food4halfq.Text = "0";
            }                                                      //Food4Halfcheckbox
            else
            {
                food4halfq.Enabled = false;                         //Food4Halfcheckbox                   //
                food4halfq.Text = "0";
            }
        }///////////////////////////////////////////////////////////////////////////////////////////////////










        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void food4fullch_CheckedChanged(object sender, EventArgs e)                                //
        {
            if (food4fullch.Checked == true)                     //FOOD 4 FULL CHECKBOX
            {
                food4fullq.Enabled = true;
                food4fullq.Text = "0";
            }                                                    //FOOD 4 FULL CHECKBOX
            else
            {
                food4fullq.Enabled = false;
                food4fullq.Text = "0";                  //FOOD 4 FULL CHECKBOX
            }                                                                                               //
        }////////////////////////////////////////////////////////////////////////////////////////////////////






        private void label2_Click(object sender, EventArgs e)
        {

        }



        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void zuush1_CheckedChanged(object sender, EventArgs e)                                   //
        {
            if (zuush1.Checked == true)                               //ZUUSH 1 CHECKBOX 
            {
                zuush1halfch.Enabled = true;
                zuush1halfq.Enabled = false;
                zuush1fullch.Enabled = true;


            }
            else
            {
                zuush1halfch.Enabled = false;
                zuush1halfq.Enabled = false;                      //ZUUSH 1 CHECKBOX
                zuush1fullch.Enabled = false;
                zuush1fullq.Enabled = false;

                zuush1halfch.Checked = false;
                zuush1halfq.Text = "0";
                zuush1fullch.Checked = false;
                zuush1fullq.Text = "0";                            //ZUUSH 1 CHECKBOX
                                                                   //
            }
        }///////////////////////////////////////////////////////////////////////////////////////////////









        ///////////////////////////////////////////////////////////////////////////////////////////////
        private void zuush1halfch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush1halfch.Checked == true)                      //ZUUSH 1 Half checkbox
            {
                zuush1halfq.Enabled = true;
                zuush1halfq.Text = "0";
            }                                                      //ZUUSH 1 Half checkbox
            else
            {
                zuush1halfq.Enabled = false;                         //ZUUSH 1 Half checkbox                   //
                zuush1halfq.Text = "0";
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////










        ///////////////////////////////////////////////////////////////////////////////////////////////
        private void zuush1fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush1fullch.Checked == true)                     //ZUUSH 1 FULL CHECKBOX
            {
                zuush1fullq.Enabled = true;
            }                                                    //ZUUSH 1 FULL CHECKBOX
            else
            {
                zuush1fullq.Enabled = false;
                zuush1fullq.Text = "0";                  //ZUUSH 1 FULL CHECKBOX
            }
        }






        private void zuush2halfch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush2halfch.Checked == true)                      //ZUUSH 2 Half checkbox
            {
                zuush2halfq.Enabled = true;
            }                                                      //ZUUSH 2 Half checkbox
            else
            {
                zuush2halfq.Enabled = false;                         //ZUUSH 2 Half checkbox                   //
                zuush2halfq.Text = "0";
            }
        }





        private void zuush2fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush2fullch.Checked == true)                     //ZUUSH 2 FULL CHECKBOX
            {
                zuush2fullq.Enabled = true;
                zuush2fullq.Text = "0";

            }                                                    //ZUUSH 2 FULL CHECKBOX
            else
            {
                zuush2fullq.Enabled = false;
                zuush2fullq.Text = "0";                  //ZUUSH 2 FULL CHECKBOX
            }
        }







        private void zuush3halfch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush3halfch.Checked == true)                      //ZUUSH 3 Half checkbox
            {
                zuush3halfq.Enabled = true;
            }                                                      //ZUUSH 3 Half checkbox
            else
            {
                zuush3halfq.Enabled = false;                         //ZUUSH 3 Half checkbox                   //
                zuush3halfq.Text = "0";

            }
        }

        private void zuush3fullch_CheckedChanged(object sender, EventArgs e)
        {
            if (zuush3fullch.Checked == true)                     //ZUUSH 3 FULL CHECKBOX
            {
                zuush3fullq.Enabled = true;
            }                                                    //ZUUSH 3 FULL CHECKBOX
            else
            {
                zuush3fullq.Enabled = false;
                zuush3fullq.Text = "0";                  //ZUUSH 3 FULL CHECKBOX
            }
        }





















































        private void button2_Click(object sender, EventArgs e)
        {



            ////////////////////////////////////////////////////////////////////////////////////
            double food1halfquantity = double.Parse(food1halfq.Text);                         ///
            double food1halfquantity_and_price = food1halfquantity * food1_half_price;

            double food1fullquantity = double.Parse(food1fullq.Text);
            double food1fullquantity_and_price = food1fullquantity * food1_full_price;
            if (food1halfch.Checked == true && food1halfquantity > -1)
            {
                total_item = total_item + food1halfquantity;
                total_price += food1halfquantity_and_price;
                total_food += food1halfquantity;
            }

            if (food1fullch.Checked == true && food1fullquantity > -1)
            {
                total_item = total_item + food1fullquantity;
                total_price += food1fullquantity_and_price;
                total_food += food1fullquantity;
            }                                                                             //
            ///////////////////////////////////////////////////////////////////////////////






            ///////////////////////////////////////////////////////////////////////////////////
            double food2halfquantity = double.Parse(food2halfq.Text);
            double food2halfquantity_and_price = food2halfquantity * food2_half_price;

            double food2fullquantity = double.Parse(food2fullq.Text);
            double food2fullquantity_and_price = food2fullquantity * food2_full_price;
            if (food2halfch.Checked == true && food2halfquantity > -1)
            {
                total_item = total_item + food2halfquantity;
                total_price += food2halfquantity_and_price;
                total_food += food2halfquantity;
            }

            if (food2fullch.Checked == true && food2fullquantity > -1)
            {
                total_item = total_item + food2fullquantity;
                total_price += food2fullquantity_and_price;
                total_food += food2fullquantity;
            }
            ///////////////////////////////////////////////////////////////////////////////////






            ////////////////////////////////////////////////////////////////////////////////////
            double food3halfquantity = double.Parse(food3halfq.Text);                         ///
            double food3halfquantity_and_price = food3halfquantity * food3_half_price;

            double food3fullquantity = double.Parse(food3fullq.Text);
            double food3fullquantity_and_price = food3fullquantity * food3_full_price;
            if (food3halfch.Checked == true && food3halfquantity > -1)
            {
                total_item = total_item + food3halfquantity;
                total_price += food3halfquantity_and_price;
                total_food += food3halfquantity;
            }

            if (food3fullch.Checked == true && food3fullquantity > -1)
            {
                total_item = total_item + food3fullquantity;
                total_price += food3fullquantity_and_price;
                total_food += food3fullquantity;
            }                                                                             //
            ///////////////////////////////////////////////////////////////////////////////




            ////////////////////////////////////////////////////////////////////////////////////
            double food4halfquantity = double.Parse(food4halfq.Text);                         ///
            double food4halfquantity_and_price = food4halfquantity * food4_half_price;

            double food4fullquantity = double.Parse(food4fullq.Text);
            double food4fullquantity_and_price = food4fullquantity * food4_full_price;
            if (food4halfch.Checked == true && food4halfquantity > -1)
            {
                total_item = total_item + food4halfquantity;
                total_price += food4halfquantity_and_price;
                total_food += food4halfquantity;
            }

            if (food4fullch.Checked == true && food4fullquantity > -1)
            {
                total_item = total_item + food4fullquantity;
                total_price += food4fullquantity_and_price;
                total_food += food4fullquantity;
            }                                                                             //
            ///////////////////////////////////////////////////////////////////////////////
            ///










            ///////////////////////////////////////////////////////////////////////////////////////
            double zuush1halfquantity = double.Parse(zuush1halfq.Text);                         ///
            double zuush1halfquantity_and_price = zuush1halfquantity * zuush1_half_price;

            double zuush1fullquantity = double.Parse(zuush1fullq.Text);
            double zuush1fullquantity_and_price = zuush1fullquantity * zuush1_full_price;  
            if (zuush1halfch.Checked == true && zuush1halfquantity > -1)
            {
                total_item = total_item + zuush1halfquantity;
                total_price += zuush1halfquantity_and_price;
                total_zuush += zuush1halfquantity;
            }

            if (zuush1fullch.Checked == true && zuush1fullquantity > -1)
            {
                total_item = total_item + zuush1fullquantity;
                total_price += zuush1fullquantity_and_price;
                total_zuush += zuush1fullquantity;
            }///////////////////////////////////////////////////////////////////////////////////////





            ///////////////////////////////////////////////////////////////////////////////////////
            double zuush2halfquantity = double.Parse(zuush2halfq.Text);                         ///
            double zuush2halfquantity_and_price = zuush2halfquantity * zuush2_half_price;

            double zuush2fullquantity = double.Parse(zuush2fullq.Text);
            double zuush2fullquantity_and_price = zuush1fullquantity * zuush2_full_price;
            if (zuush2halfch.Checked == true && zuush2halfquantity > -1)
            {
                total_item = total_item + zuush2halfquantity;
                total_price += zuush2halfquantity_and_price;
                total_zuush += zuush2halfquantity;
            }

            if (zuush2fullch.Checked == true && zuush2fullquantity > -1)
            {
                total_item = total_item + zuush2fullquantity;
                total_price += zuush2fullquantity_and_price;
                total_zuush += zuush2fullquantity;///
            }///////////////////////////////////////////////////////////////////////////////////////






            ///////////////////////////////////////////////////////////////////////////////////////
            double zuush3halfquantity = double.Parse(zuush3halfq.Text);                         ///
            double zuush3halfquantity_and_price = zuush3halfquantity * zuush3_half_price;

            double zuush3fullquantity = double.Parse(zuush3fullq.Text);
            double zuush3fullquantity_and_price = zuush3fullquantity * zuush3_full_price;
            if (zuush3halfch.Checked == true && zuush3halfquantity > -1)
            {
                total_item = total_item + zuush3halfquantity;
                total_price += zuush3halfquantity_and_price;
                total_zuush += zuush3halfquantity;
            }

            if (zuush3fullch.Checked == true && zuush3fullquantity > -1)
            {
                total_item = total_item + zuush3fullquantity;
                total_price += zuush3fullquantity_and_price;
                total_zuush += zuush3fullquantity;///
            }///////////////////////////////////////////////////////////////////////////////////////


            if(total_food==2 && total_zuush==1)
            {
                discount1 = total_price-((total_price / 100) * 4);
            }

            if (total_food == 2 && total_zuush == 2)
            {
                discount1 = total_price - ((total_price / 100) * 8);
            }

            if (total_price > 150)
            {
                discount1 = total_price - ((total_price / 100) * 15);
            }





















            MessageBox.Show("Та нийт:  " + total_item + " ширхэг хоол захиаллаа\n" +
               "Таны хоолны төлбөр " + total_price+ "\n"+ "(Хөнгөлөгдсөн төлбөр) = "+ discount1);


            food1halfq.Text = "0";
            food1fullq.Text = "0";
            food2halfq.Text = "0";
            food2fullq.Text = "0";
            food3halfq.Text = "0";
            food3fullq.Text = "0";
            food4halfq.Text = "0";
            food4fullq.Text = "0";




            zuush1halfq.Text = "0";
            zuush1fullq.Text = "0";
            zuush2halfq.Text = "0";
            zuush2fullq.Text = "0";
            zuush3halfq.Text = "0";
            zuush3fullq.Text = "0";


        }









































































































































































































        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void zuush1halfq_TextChanged(object sender, EventArgs e)
        {

        }

        private void zuush2fullq_TextChanged(object sender, EventArgs e)
        {

        }

        private void zuush2halfq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
