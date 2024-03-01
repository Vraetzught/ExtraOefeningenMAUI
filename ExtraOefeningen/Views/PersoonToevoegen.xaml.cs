using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class PersoonToevoegen : ContentPage
{
    public PersoonToevoegen(PersoonToevoegenViewModel ptvm)
    {
        InitializeComponent();
        BindingContext = ptvm;
    }
}