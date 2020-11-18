using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Helpers.Constants
{
    public static class PaymentMethods
    {
        public static string BancoDoBrasil { get; } = "BB_TRANSFER";
        public static string Bradesco { get; } = "BRADESCO_TRANSFER";
        public static string Itau { get; } = "ITAU_TRANSFER_GENERIC";
        public static string ItauPF { get; } = "ITAU_TRANSFER_PF";
        public static string ItauPJ { get; } = "ITAU_TRANSFER_PJ";
        public static string ItauDI { get; } = "ITAU_DI";
        public static string Caixa { get; } = "CEF_TRANSFER";
        public static string Original { get; } = "ORIGINAL_TRANSFER";
        public static string Santander { get; } = "SANTANDER_TRANSFER";
        public static string SantanderDI { get; } = "SANTANDER_DI";
        public static string Inter { get; } = "INTER_TRANSFER";
        public static string BS2 { get; } = "BS2_TRANSFER";
        public static string OutrosBancos { get; } = "OUTROS_BANCOS";
        public static string PIX { get; } = "PIX";
    }
}
