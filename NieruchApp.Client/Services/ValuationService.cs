using NieruchApp.Client.Models;
using System.ComponentModel;

namespace NieruchApp.Client.Services
{
    public class ValuationService
    {
        public async Task<List<ValuationStepDto>> GetValuationSteps()
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
                }
                ];
        }
    }
}
