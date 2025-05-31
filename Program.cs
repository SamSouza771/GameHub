using Spectre.Console;

namespace gamehub
{
	 public static class Program {
		public static void Main(string[] args) {
			string path = @"C:\\Users\\SAM\\Documents\\jogos";

			var arquivos = Directory.GetFiles(path);
			var nomes = new List<string>();
			foreach (var arquivo in arquivos)
			{
				    var nome = Path.GetFileNameWithoutExtension(arquivo);
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
				    FileName = @$"C:\\Users\\SAM\\Documents\\jogos\\{programa}.lnk",
					UseShellExecute = true
			};

			System.Diagnostics.Process.Start(processo);
		}
	}
}
