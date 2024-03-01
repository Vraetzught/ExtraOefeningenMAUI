using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class GamePage : ContentPage
{
    public GamePage(GameViewModel gvm)
    {
        InitializeComponent();
        BindingContext = gvm;
    }
}