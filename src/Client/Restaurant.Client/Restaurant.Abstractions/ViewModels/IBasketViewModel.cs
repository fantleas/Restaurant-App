﻿using ReactiveUI;

namespace Restaurant.Abstractions.ViewModels
{
    public interface IBasketViewModel : INavigatableViewModel
    {
        ReactiveList<IOrderViewModel> Orders { get; }

        string OrdersCount { get; }

        void AddOrder(IOrderViewModel order);
    }
}