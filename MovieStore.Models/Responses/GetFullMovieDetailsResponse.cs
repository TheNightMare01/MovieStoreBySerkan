using MovieStore.Models.Views;

namespace MovieStore.Models.Responses
{
	public class GetFullMovieDetailsReponse
	{
		IEnumerable<MovieView> Movies { get; set; } = [];
	}
}
