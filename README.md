# SharpPaymee

SharpPaymee é uma implementação da API da Paymee Empresas em C# usando .NET Standard.

Para começar a usar você primeiro precisa solicitar a key e o token junto a Paymee.

A Documentação da API está em https://documenter.getpostman.com/view/3199663/RWM6zDGc?version=latest#intro

Para instalar no seu projeto, basta abrir o console do package manager e execute:

            Install-Package Paymee.API -Version 1.0.6

############################ WORK IN PROGRESS #####################################

A Maioria dos metodos já estão implementados porem ainda sem testes, para usar é só seguir o exemplo abaixo.
Exemplo:

            using (var paymee = new API.Paymee("SUA API KEY", "SUA API TOKEN", true))
            {
                var request = new API.Models.CheckOutRequest
                {
                    Amount = 10,
                    Currency = "BRL",
                    MaxAge = 120,
                    ReferenceCode = "123",
                    PaymentMethod = API.Helpers.Constants.PaymentMethods.Itau //BANCO,
                    Shopper = new API.Models.Shopper
                    {
                        Id = 10,
                        Name = "NOME CLIENTE",
                        Email = "EMAIL DO CLIENTE",
                        BankDetails = new API.Models.BankDetails
                        {
                            Account = "CONTA DO CLIENTE",
                            Branch = "AGENCIA DO CLIENTE"
                        },
                        Document = new API.Models.Document
                        {
                            Number = "CPF DO CLIENTE",
                            Type = "CPF"
                        },
                        Phone = new API.Models.Document
                        {
                            Type = "MOBILE",
                            Number = "CELULAR DO CLIENTE"
                        }
                    },
                    CallbackUrl = new Uri("URL DO SEU WEBHOOK")
                };

                var result = paymee.GenerateCheckout(request).Result;
            }
            
            
Caso queira contribuir para a biblioteca, fique livre para fazer um pull request.

Espero estar ajudando.
