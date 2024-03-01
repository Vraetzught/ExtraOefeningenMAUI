using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class Afbeelding : ContentPage
{
    public Afbeelding(AfbeeldingViewModel avm)
    {
        InitializeComponent();
        BindingContext = avm;
    }
}