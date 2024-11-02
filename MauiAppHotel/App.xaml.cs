﻿using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> list_quartos = new List<Quarto>
        {
            new Quarto()
           {
            Descricao = "Suite Super Luxo,",
            ValorDiariaAdulto = 110.00,
            ValorDiariaCrianca = 55.00
            },
            new Quarto()
            {
            Descricao = "Suite Luxo,",
            ValorDiariaAdulto = 80.00,
            ValorDiariaCrianca = 40.00
            },
            new Quarto()
            {
            Descricao = "Suite Single",
            ValorDiariaAdulto = 50.00,
            ValorDiariaCrianca = 12.50
            },
            new Quarto()
            {
            Descricao = "Suite Crise",
            ValorDiariaAdulto = 50.00,
            ValorDiariaCrianca = 25.00
            }
         };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}