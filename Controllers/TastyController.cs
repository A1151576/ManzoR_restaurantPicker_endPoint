/*
                    Rafael Manzo
                Restaurant Picker end Point
                    10/27/2022
Peer Reviewed by Dan Decoito: The program and the api work really well. The code is concise. Kudos 

*/

using Microsoft.AspNetCore.Mvc;

namespace ManzoR_restaurantPicker_endPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class TastyController : ControllerBase
{
    [HttpGet]
    [Route("Yummers")]

    public string Tastee( )
    {
        Random randomNum = new Random();
        string[] places = new string[] { "I HOP", "Alberto's Mexican Restaurant", "Noah's NY Bagels", "Panera Bread", "Tommy's Cafe", "Taco Bell", "Besito's", "Chik-Fil-A", "American Waffles", "McDonalds" };
        int allchoice = randomNum.Next(0, 10);
    
        return places [allchoice];


    }

}
