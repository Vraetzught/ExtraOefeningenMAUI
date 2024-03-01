using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class GetallenRij : ContentPage
{
    public GetallenRij(GetallenRijViewModel grvm)
    {
        InitializeComponent();
        BindingContext = grvm;
    }
}