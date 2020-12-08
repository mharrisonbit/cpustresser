﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPUStresser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RunApp = false;
        }

        public bool RunApp { get; private set; }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                RunApp = true;
                while (RunApp)
                //for (int x = 0; x < 100000; x++)
                {
                    await Task.Delay(5);
                    var num = 123456789987654321;
                    // bool isPrime = true;
                    for (long i = 0; i <= num; i++)
                    {
                        bool isPrime = true; // Move initialization to here
                        for (long j = 2; j < i; j++) // you actually only need to check up to sqrt(i)
                        {
                            if (i % j == 0) // you don't need the first condition
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            Console.WriteLine("Prime:" + i);
                        }
                        // isPrime = true;
                    }
                }
            });
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            throw new Exception();
        }
    }
}
