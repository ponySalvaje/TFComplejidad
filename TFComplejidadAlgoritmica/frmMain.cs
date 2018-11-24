using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFComplejidadAlgoritmica.Kruskal;

namespace TFComplejidadAlgoritmica
{
    public partial class frmMain : Form
    {

        #region Member Variables

        const int _radius = 20;
        const int _halfRadius = (_radius / 2);

        Color _vertexColor = Color.Aqua;
        Color _edgeColor = Color.Red;

        IList<Vertex> _vertices;
        IList<Edge> _graph, _graphSolved;

        Vertex _firstVertex, _secondVertex;

        bool _drawEdge, _solved;

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }
        
    }
}
