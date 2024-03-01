using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class Factuur : ContentPage
{
    public Factuur(FactuurViewModel fvm)
    {
        InitializeComponent();
        BindingContext = fvm;
    }
}