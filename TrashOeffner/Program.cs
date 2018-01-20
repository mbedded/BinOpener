using System.Diagnostics;

namespace TrashOeffner {

  class Program {

    static void Main(string[] args) {
      // This one opens the RecycleBin.
      // Source: http://www.codeproject.com/Tips/197213/Show-MyComputer-ControlPanel-RecycleBin-NetworkPla
      Process.Start("explorer.exe", "/root,::{645FF040-5081-101B-9F08-00AA002F954E}");
    }

  }

}