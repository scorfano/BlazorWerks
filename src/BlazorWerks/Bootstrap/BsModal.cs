﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsModal : BsComponent
    {

        public BsModal(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Modal"; }

        public BsModal HandleUpdate()
        { return Invoke<BsModal>("handleUpdate"); }

        public BsModal Hide()
        { return Invoke<BsModal>("hide"); }

        public BsModal Show()
        { return Invoke<BsModal>("show"); }

        public BsModal Toggle()
        { return Invoke<BsModal>("toggle"); }
    }
}