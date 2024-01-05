using AspExos.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspExos.Views.RandomNumber.Components.RandomNumber;

public class RandomNumberViewComponent : ViewComponent
{
    private readonly IRandomService _randomService;

    public RandomNumberViewComponent(IRandomService randomService)
    {
        _randomService = randomService;
    }

    public IViewComponentResult Invoke(int min, int max)
    {
        int number = _randomService.GenerateRandomNumber(min, max);

        return View((min, max, number));
    }
}
