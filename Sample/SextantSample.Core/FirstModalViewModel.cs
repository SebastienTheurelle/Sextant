﻿using System.Reactive;
using ReactiveUI;
using Sextant;
using System;
using System.Diagnostics;

namespace SextantSample.ViewModels
{
    public class FirstModalViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> OpenModal { get; set; }

        public ReactiveCommand<Unit, Unit> PopModal { get; set; }

        public override string Id => nameof(FirstModalViewModel);

        public FirstModalViewModel(IViewStackService viewStackService) : base(viewStackService)
        {
            OpenModal = ReactiveCommand
                        .CreateFromObservable(() =>
                            ViewStackService.PushModal(new SecondModalViewModel(viewStackService)),
                            outputScheduler: RxApp.MainThreadScheduler);

            PopModal = ReactiveCommand
                        .CreateFromObservable(() =>
                            ViewStackService.PopModal(),
                            outputScheduler: RxApp.MainThreadScheduler);

            OpenModal.Subscribe(x => Debug.WriteLine("PagePushed"));
            PopModal.Subscribe(x => Debug.WriteLine("PagePoped"));
            PopModal.ThrownExceptions.Subscribe(error => Interactions.ErrorMessage.Handle(error).Subscribe());
        }
    }
}
