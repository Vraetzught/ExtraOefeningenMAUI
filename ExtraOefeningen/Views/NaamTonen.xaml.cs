using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class NaamTonen : ContentPage
{
    public NaamTonen(NaamTonenViewModel ntvm)
    {
        InitializeComponent();
        BindingContext = ntvm;
    }
    
}