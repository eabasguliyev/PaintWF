using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PaintWF.Entities;
using PaintWF.Helpers;
using PaintWF.Interfaces;
using Rectangle = PaintWF.Entities.Rectangle;

namespace PaintWF
{
    public partial class Form1 : Form
    {
        public ICreator FigureCreator { get; set; }
        public List<IFigure> Figures { get; set; }
        private Color _color;
        private Pen _pen;
        private SolidBrush _solidBrush;
        private bool _isFilled;
        public Form1()
        {
            InitializeComponent();

            Figures = new List<IFigure>();
            var figures = new List<string>()
            {
                "Rectangle",
                "Circle",
                "Triangle",
            };
            ComboBoxFigures.DataSource = figures;
            ComboBoxFigures.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelTools.Enabled = false;
        }

        private void PanelPaintArea_Paint(object sender, PaintEventArgs e)
        {
            if (Figures.Count == 0)
                return;

            using (var g = e.Graphics)
            {
                foreach (var figure in Figures)
                {
                    if (figure.IsFilled)
                        _solidBrush = new SolidBrush(figure.Color);
                    else
                    {
                        _pen = new Pen(figure.Color);
                    }


                    switch (figure)
                    {
                        case Rectangle rf when rf.IsFilled:
                            g.FillRectangle(_solidBrush, rf.Point.X, rf.Point.Y, rf.Size.Width, rf.Size.Height);
                            break;
                        case Rectangle rf:
                            g.DrawRectangle(_pen, rf.Point.X, rf.Point.Y, rf.Size.Width, rf.Size.Height);
                            break;
                        case Circle cf when cf.IsFilled:
                            g.FillEllipse(_solidBrush, figure.Point.X, figure.Point.Y, figure.Size.Width, figure.Size.Height);
                            break;
                        case Circle cf:
                            g.DrawEllipse(_pen, cf.Point.X, cf.Point.Y, cf.Size.Width, cf.Size.Height);
                            break;
                        case Triangle tf:
                        {
                            var points = new Point[]
                            {
                                new Point(figure.Point.X, figure.Point.Y),
                                new Point(figure.Point.X - figure.Size.Width / 2, figure.Point.Y + figure.Size.Height),
                                new Point(figure.Point.X + figure.Size.Width / 2, figure.Point.Y + figure.Size.Height),
                            };

                            if (tf.IsFilled)
                            {
                                g.FillPolygon(_solidBrush, points);
                            }
                            else
                            {
                                g.DrawPolygon(_pen, points);
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void ComboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            var figureName = ComboBoxFigures.SelectedItem as string;


            switch (figureName)
            {
                case "Rectangle":
                    FigureCreator = new RectangleCreator();
                    break;
                case "Circle":
                    FigureCreator = new CircleCreator();
                    break;
                case "Triangle":
                    FigureCreator = new TriangleCreator();
                    break;
                default:
                    break;
            }
        }

        private void CheckBoxManual_CheckedChanged(object sender, EventArgs e)
        {
            PanelProperties.Enabled = !CheckBoxManual.Checked;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Figures.Clear();
            PanelPaintArea.Refresh();
        }

        private void RadioButtonPen_CheckedChanged(object sender, EventArgs e)
        {
            _isFilled = !RadioButtonPen.Checked;
        }

        private void ButtonSelectColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                _color = colorDialog.Color;
                PanelTools.Enabled = true;
            }
        }

        private void RadioButtonBrush_CheckedChanged(object sender, EventArgs e)
        {
            _isFilled = RadioButtonBrush.Checked;
        }

        private void PanelPaintArea_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelPaintArea_MouseClick(object sender, MouseEventArgs e)
        {
            var figureName = ComboBoxFigures.SelectedItem as string;

            var loc = e.Location;
            var width = Convert.ToInt32(TextBoxWidth.Text);
            var height = Convert.ToInt32(TextBoxHeight.Text);

            var figure = FigureCreator.CreateFigure();

            figure.Name = figureName;
            figure.Point = loc;
            figure.Size = new Size(width, height);
            figure.Color = _color;
            figure.IsFilled = _isFilled;
            Figures.Add(figure);

            this.Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();

            save.Filter = "Json files | *.json";

            if (save.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = save.FileName.EndsWith(".json") ? save.FileName : save.FileName + ".json";


            var fileHelper = new JsonHelper();

            fileHelper.Serialize(fileName, Figures);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            open.Filter = "Json files | *.json";

            if (open.ShowDialog() == DialogResult.Cancel)
                return;

            var fileHelper = new JsonHelper();

            Figures = fileHelper.Deserialize(open.FileName);
        }
    }
}
