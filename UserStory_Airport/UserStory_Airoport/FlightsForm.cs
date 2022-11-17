using System;
using System.Drawing;
using System.Windows.Forms;
using UserStory_Airoport.models;

namespace UserStory_Airoport
{
    public partial class FlightsForm : System.Windows.Forms.Form
    {
        private readonly Reisi flights;
        public string text = "Boeing";

        public FlightsForm()
        {
            InitializeComponent();
            FillDirection();
            this.Text = "Добавление рейса";
            flights = new Reisi
            {
                nomer_reisa = 1,
                type = Types.Boeing,
                prib_time = DateTime.Now.AddDays(1),
                passagiers_count = (int)count_pas.Value,
                ppassagiers__price = (double)pas_price.Value,
                ek_count = (int)ekCrew.Value,
                ek_price = (double)ekprice.Value,
                procent = (double)procent.Value,
                allmoney = 2
            };
            type.SelectedItem = flights.type;
        }

        public FlightsForm(Reisi source):this()
        {
            this.Text = "Редактирование рейса";
            reis.Value = source.nomer_reisa;
            type.SelectedItem = source.type;
            pribTime.Value = source.prib_time;
            count_pas.Value = source.passagiers_count;
            ekCrew.Value = source.ek_count;
            pas_price.Value = (decimal)source.ppassagiers__price;
            ekprice.Value = (decimal)source.ek_price;
            procent.Value = (decimal)source.procent;
            allmoney.Text = source.allmoney.ToString();
        }
        public Reisi Flights => flights;

        private void FillDirection()
        {
            foreach(Types type in Enum.GetValues(typeof(Types)))
            {
                this.type.Items.Add(type);
            }
        }

        private void comboType_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if(parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if(e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Types type)
                    {
                        text = type.ToString();
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                    e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
                
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(type.SelectedIndex >= 0)
            {
                flights.type = (Types)type.SelectedItem;
            }
        }

        private void numericFlight_ValueChanged(object sender, EventArgs e)
        {
            flights.nomer_reisa = (int)reis.Value;
        }

        private void dateTimeETA_ValueChanged(object sender, EventArgs e)
        {
            flights.prib_time = pribTime.Value;
        }

        private void numericCountPas_ValueChanged(object sender, EventArgs e)
        {
            flights.passagiers_count = (int)count_pas.Value;
            allmoney.Text = ((flights.passagiers_count * flights.ppassagiers__price + flights.ek_count * flights.ek_price) *
                (1 + flights.procent * 0.01)).ToString();
        }

        private void numericPricePas_ValueChanged(object sender, EventArgs e)
        {
            flights.ppassagiers__price = (double)pas_price.Value;
            allmoney.Text = ((flights.passagiers_count * flights.ppassagiers__price + flights.ek_count * flights.ek_price) *
                (1 + flights.procent * 0.01)).ToString();
        }

        private void numericCountCrew_ValueChanged(object sender, EventArgs e)
        {
            flights.ek_count = (int)ekCrew.Value;
            allmoney.Text = ((flights.passagiers_count * flights.ppassagiers__price + flights.ek_count * flights.ek_price) *
                (1 + flights.procent * 0.01)).ToString();
        }

        private void numericPriceCrew_ValueChanged(object sender, EventArgs e)
        {
            flights.ek_price = (double)ekprice.Value;
            allmoney.Text = ((flights.passagiers_count * flights.ppassagiers__price + flights.ek_count * flights.ek_price) *
                (1 + flights.procent * 0.01)).ToString();
        }
        private void numericProcDop_ValueChanged(object sender, EventArgs e)
        {
            flights.procent = (int)procent.Value;
            allmoney.Text = ((flights.passagiers_count * flights.ppassagiers__price + flights.ek_count * flights.ek_price) *
                (1 + flights.procent * 0.01)).ToString();
        }

        private void textSum_TextChanged(object sender, EventArgs e)
        {
            flights.allmoney = double.Parse(allmoney.Text);
        }
    }
}
