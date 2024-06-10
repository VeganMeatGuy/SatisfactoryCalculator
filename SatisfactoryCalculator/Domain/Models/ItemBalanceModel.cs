﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisfactoryCalculator.Domain.Models;

internal class ItemBalanceModel
{
    private ItemModel _item = new();
    private decimal _inAmount = 0;
    private decimal _outAmount = 0;

    public ItemModel Item
    {
        get => _item;
        set => _item = value;
    }

    public decimal InAmount
    {
        get => _inAmount;
        set => _inAmount = value;
    }

    public decimal OutAmount
    {
        get => _outAmount;
        set => _outAmount = value;
    }
}