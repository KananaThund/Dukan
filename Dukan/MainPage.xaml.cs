using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Dukan
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            FillPhases();
        }

        private void FillPhases()
        {
            Phases attack = new Phases("Атака", "Описание того, чего можно, а чего нельзя и воообщзелофыдвлождлфыаождлымосджчсляомдлячсомдлчясомждлоячсмдлочясджмлочсдмлочдлсомдлоыв");
        }

        private void _cbPhase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string a = (_cbPhase.SelectedItem as ComboBoxItem).Content.ToString();

            if (a == "Атака")
                _tbDesciption.Text = "desc_txt1";
            else
            {
                if (a == "Чередование")
                    _tbDesciption.Text = "desc_txt2";
                else
                {
                    if (a == "Стабилизация")
                        _tbDesciption.Text = "desc_txt3";
                    else
                    {
                        if (a == "Закрепление")
                            _tbDesciption.Text = "desc_txt4";
                    }
                }
            }
        }


    }
}

