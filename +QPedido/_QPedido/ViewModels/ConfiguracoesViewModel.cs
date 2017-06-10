﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Services;
using _QPedido.Models;

namespace _QPedido.ViewModels
{
    public class Opcoes
    {
        public string Descricao { get; set; }

        public Opcoes(string descricao )
        {
            Descricao = descricao;
        }
    }


    public class ConfiguracoesViewModel : BindableBase
    {
        private readonly IPageDialogService _dialogService;

        private ObservableCollection<Opcoes> _lista;
        

        public DelegateCommand ItemTappedCommand { get; set; }

        public ObservableCollection<Opcoes> Lista
        {
            get { return _lista; }
            set { SetProperty(ref _lista, value); }
        }

        public ConfiguracoesViewModel(IPageDialogService dialogService)
        {
            _dialogService = dialogService;

            Lista = new ObservableCollection<Opcoes>();
            ItemTappedCommand = new DelegateCommand(ItemTapped);
            for (int i = 0; i < 4; i++)
            {
                Lista.Add(new Opcoes( $"Opção {i}"));
            }
        }

        private void ItemTapped()
        {
            _dialogService.DisplayAlertAsync("Aviso", "Tocou", "OK");
        }


    }
}
