using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Helpers.Constants
{
    public static class PaymentMethods
    {
        public static string BancoDoBrasil { get; set; } = "BB_TRANSFER";
        public static string Bradesco { get; set; } = "BRADESCO_TRANSFER";
        public static string Itau { get; set; } = "ITAU_TRANSFER_GENERIC";
        public static string ItauPF { get; set; } = "ITAU_TRANSFER_PF";
        public static string ItauPJ { get; set; } = "ITAU_TRANSFER_PJ";
        public static string ItauDI { get; set; } = "ITAU_DI";
        public static string Caixa { get; set; } = "CEF_TRANSFER";
        public static string Original { get; set; } = "ORIGINAL_TRANSFER";
        public static string Santander { get; set; } = "SANTANDER_TRANSFER";
        public static string SantanderDI { get; set; } = "SANTANDER_DI";
        public static string Inter { get; set; } = "INTER_TRANSFER";
        public static string BS2 { get; set; } = "BS2_TRANSFER";
        public static string OutrosBancos { get; set; } = "OUTROS_BANCOS";
    }
}
