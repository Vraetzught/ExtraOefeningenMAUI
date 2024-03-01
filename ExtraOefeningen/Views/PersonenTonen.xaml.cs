using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class PersonenTonen : ContentPage
{
    public PersonenTonen(PersonenTonenViewModel ptvm)
    {
        InitializeComponent();
        BindingContext = ptvm;
    }
}