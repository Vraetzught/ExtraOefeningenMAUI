using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefeningen.Views;

public partial class GetallenDoorgeven2 : ContentPage
{
    public GetallenDoorgeven2(GetallenDoorgeven2ViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}