using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            RulesGame.Text = "   Привітик! Ви зараз граєте гру Попади в м'ячик.\n" +
                "1. Щоб в неї зіграти вам потрібно натиснути на кнопку Розпочати гру.\n" +
                "2. Потім нажимаєте на м'ячики, які з'являтимуться на екрані.\n" +
                "3. Розподіл очок: Жовтий - 10 балів, Голубий - 20 балів, Зелений - 30 балів.\n" +
                "4. Якщо ж бачите червоний м'ячик, то ні в якому разі не натискайте на нього він відбере у вас 50 очок.\n" +
                "5. Якщо ж пропускатимете м'ячики, то будуть нараховуватись штрафні бали.\n" +
                "6. Гра закінчиться тоді, коли ви втратили 100 очків\n" +
                "7. З кожним разом м'ячкии з'являтимуться все швидше, тому старайтесь не програти!\n\n";
        }
    }
}
