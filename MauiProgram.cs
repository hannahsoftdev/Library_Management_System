// ----------------------------------------------------------------------------------------
// File: MauiProgram.cs
// Author: Hannah Mae Tolentino
// Student ID: 000953335
// Course: CPRG-211-E
// Date: April 2025
// ----------------------------------------------------------------------------------------
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace LibraryManagementSystem
{
/// <summary>
/// Configures and builds the MAUI application.
/// </summary>
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();
            return builder.Build();
        }
    }
}
