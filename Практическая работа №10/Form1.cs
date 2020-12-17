using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Практическая_работа__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //первое отображение формы
        private void Form1_Shown(object sender, EventArgs e)
        {
            table.ColumnCount = 5;//столбцы
            table.RowCount = 1;//строки
        }
        //заполнить
        private void button1_Click(object sender, EventArgs e)
        {
           int kol = Convert.ToInt32(kol1.Value);//длина массива
            int min = (Int32)min1.Value;//минимальное значение диапазона
            int max = (Int32)max1.Value;//максимальное значение диапазона
            Random rand = new Random();
            for (int i = 0; i < kol; i++)
            {
                table[i, 0].Value = rand.Next(min, max);//заполнение массива (таблицы)
            }
        }
        //Вычислить
        private void button2_Click(object sender, EventArgs e)
        {
            int min, max;//минимальное и максимаьное числа
            max = 0;
            min = 0;

            for (int i = 0; i < table.ColumnCount; i++) //перемещаемся по массиву (таблице)
            {
                if (Int32.TryParse(Convert.ToString(table[i, 0].Value), out int x) == true)//если массив заполнен правильно
                {
                    if (x%2==0) //проверяем на четность
                        if (x>max) max=x;//если х больше максимального, то присваиваем это значение

                    if (Int32.TryParse(Convert.ToString(A1.Text), out int A) == true)//если поле заполнено верно
                    {
                        if (x % A == 0)//если число кратно А
                            if (x < min) min = x;//если число меньше минимального А, то присваиваем это значение
                    }
                    else 
                    { //иначе выводим сообщение об ошибке и прерываем
                        MessageBox.Show("Введите корректное число А");
                        break;
                    }
                }
                else
                {//иначе выводим сообщение об ошибке и прерываем
                    MessageBox.Show("Заполните таблицу числами!");
                    break;
                }
                
            }
            maxRez1.Text = Convert.ToString(max);//результат Максимальное четное
            minRez1.Text = Convert.ToString(min);//результат Минимальное кратное А
        }
        //при изменении количества столбцов меняем размер таблицы
        private void kol1_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(kol1.Value);
        }
    }
}
