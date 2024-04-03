## Bibliografia
- Dotnet-Bot. (s. f.). Regex.IsMatch Método (System.Text.RegularExpressions). Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-8.0
- GfG. (2023, 19 febrero). C Equals(String, string) method. GeeksforGeeks. https://www.geeksforgeeks.org/c-sharp-equalsstring-string-method/
- ChatGPT. (s. f.). https://chat.openai.com/?model=text-davinci-002-render-sha
  ### IA CONSULTADA:
  ##### CHAT GPT:
- Prompts: tengo este codigo:    public static Score[] GenerateUniqueRanking(List<Score>scores)
   {
       List<Score> ranking = new List<Score>();
       List<string> missions = new List<string>();
       foreach (Score score in scores)
       {
           if (!missions.Contains(score.Mission))
           {
               missions.Add(score.Mission);
               ranking.Add(score);
           }
       }
       return ranking.OrderByDescending(score => score.Scoring).ToArray();
   }
pero en el caso que tenga un jugador con el nombre Arnau, en la mision Delta-001 y 500 de puntuacion y tenga otro con otro nombre, con la mision Delta-001 tambien y 400 de puntuacion tambien quiero que lo muestre en caso de que sea su mejor puntuacion. Osea quiero que el filtro devuelva las misiones con mejor puntuacion de cada Jugador

- Retorns: Entiendo, necesitas ajustar la lógica para que devuelva las misiones con la mejor puntuación de cada jugador. Podemos modificar la función para que primero agrupe las puntuaciones por el nombre del jugador y la misión, luego seleccione la puntuación más alta de cada grupo y finalmente devuelva los resultados ordenados por puntuación. Aquí está cómo puedes hacerlo:
  public static Score[] GenerateUniqueRanking(List<Score> scores)
{
    Dictionary<string, Score> bestScores = new Dictionary<string, Score>();

    foreach (Score score in scores)
    {
        // Verifica si ya hay un registro para esta misión y jugador
        if (!bestScores.ContainsKey(score.Player + score.Mission) ||
            bestScores[score.Player + score.Mission].Scoring < score.Scoring)
        {
            // Si es la mejor puntuación hasta ahora para esta misión y jugador, actualiza el registro
            bestScores[score.Player + score.Mission] = score;
        }
    }

    // Convierte los valores del diccionario en una lista y ordénalos por puntuación de forma descendente
    List<Score> ranking = bestScores.Values.OrderByDescending(score => score.Scoring).ToList();

    return ranking.ToArray();

}
  ##### CHAT GPT:
  - Prompts: User
se puede hacer lo mismo sin un diccionario?
  - Retorns: 
Sí, puedes hacerlo sin un diccionario. Puedes utilizar LINQ para agrupar las puntuaciones por jugador y misión, luego seleccionar la puntuación más alta de cada grupo y finalmente ordenar los resultados por puntuación. Aquí tienes una versión actualizada del método GenerateUniqueRanking que no utiliza un diccionario:public static Score[] GenerateUniqueRanking(List<Score> scores)
{
    var uniqueScores = scores
        .GroupBy(score => new { score.Player, score.Mission })
        .Select(group => group.OrderByDescending(score => score.Scoring).First())
        .OrderByDescending(score => score.Scoring)
        .ToArray();

    return uniqueScores;
}
Esta implementación utiliza LINQ para agrupar las puntuaciones por jugador y misión, luego selecciona la puntuación más alta de cada grupo y finalmente ordena los resultados por puntuación en orden descendente. De esta manera, obtendrás las mejores puntuaciones para cada misión de cada jugador.
 
  ##### CHAT GPT:
  - Prompts: crea un regex de : mission: ha de contenir com a prefix el nom adaptat de les lletres en grec, seguit d’un guió i un número de 3 xifres. Per exemple: Delta-003
  - Retorns: Para cumplir con los requisitos que has especificado, puedes utilizar la siguiente expresión regular: ^[A-Za-z]*-(\d{3})$








