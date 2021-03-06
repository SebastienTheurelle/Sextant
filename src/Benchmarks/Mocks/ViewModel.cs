﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace Sextant.Benchmarks
{
    /// <summary>
    /// View model for benchmarking.
    /// </summary>
    /// <seealso cref="IPageViewModel" />
    public class ViewModel : IPageViewModel
    {
        /// <inheritdoc />
        public string Id { get; } = nameof(ViewModel);
    }
}
