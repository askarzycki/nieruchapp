using NieruchApp.Client.Models;
using System.ComponentModel;

namespace NieruchApp.Client.Services
{
    public class ValuationService
    {
        public async Task<ValuationStepDto[]> GetValuationSteps()
        {
            return [
                new ValuationStepDto()
                {
                    Header = "Wiek budynku",
                    Prompt = "Wybierz odpowiedni przedział wiekowy.",
                    Options = [
                        new()
                        {
                            OptionId = 11,
                            Label = "Nowy (do 5 lat)" 
                        },
                        new()
                        {
                            OptionId = 12,
                            Label = "5 - 15 lat"
                        },
                        new()
                        {
                            OptionId = 13,
                            Label = "15 -  30 lat"
                        },
                        new()
                        {
                            OptionId = 14,
                            Label = "powyżej 30 lat"
                        }
                    ]
                },
                new ValuationStepDto()
                {
                    Header = "Piętro",
                    Prompt = "Wybierz piętro. Piętra środkowe to kondygnacje od drugiej do przedostatniej.",
                    Options = [
                        new()
                        {
                            OptionId = 21,
                            Label = "Parter"
                        },
                        new()
                        {
                            OptionId = 22,
                            Label = "Środkowe piętro"
                        },
                        new()
                        {
                            OptionId = 23,
                            Label = "Ostatnie piętro"
                        }
                    ]
                },
                new ValuationStepDto()
                {
                    Header = "Bezpośrednie otoczenie",
                    Prompt = "",
                    Options = [
                        new()
                        {
                            OptionId = 31,
                            Label = "Historyczna zabudowa (kamienice, wille miejskie)"
                        },
                        new()
                        {
                            OptionId = 32,
                            Label = "Nowe budownictwo i/lub domy jednorodzinne"
                        },
                        new()
                        {
                            OptionId = 33,
                            Label = "Tereny mieszkalne z przewagą starszego budownictwa"
                        },
                        new()
                        {
                            OptionId = 34,
                            Label = "Tereny usługowe (magazyny, sklepy wielkopwierzchniowe, parkingi)"
                        },
                        new()
                        {
                            OptionId = 35,
                            Label = "Tereny przemysłowe (w tym uciążliwe zakłady, składowiska odpadów, stacje paliw itp.)"
                        }
                    ]
                }
                ];
        }
        public async Task<ValuationResultDto> CalculatePrice(ValuationSummaryDto valuationSummary)
        {
            return new ValuationResultDto() { EstimatedPrice = 10000.543 };
        }
    }
}
