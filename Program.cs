using Spectre.Console;

namespace gamehub
{
	 public static class Program {
		public static void Main(string[] args) {
			var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
	        var pathfdr = Path.Combine(path, "jogos\\");

			var arquivos = Directory.GetFiles(pathfdr);
			var nomes = new List<string>();
			foreach (var arquivo in arquivos)
			{
				    var nome = Path.GetFileName(arquivo);
					nomes.Add(nome);
			}
			var panel = new Panel("nha");
			AnsiConsole.Write(
				    new FigletText("GameHub")
					        .LeftJustified()
							        .Color(Color.Red));
			
			var programa = AnsiConsole.Prompt(
				new  SelectionPrompt<string>()
				
				.PageSize(10)
				.AddChoices(nomes)
			);

			var processo = new System.Diagnostics.ProcessStartInfo
			{
				    FileName = @$"{pathfdr}{programa}",
					UseShellExecute = true
			};

			System.Diagnostics.Process.Start(processo);
		}
	}
}
