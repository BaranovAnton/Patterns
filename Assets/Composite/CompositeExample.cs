using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeExample : MonoBehaviour
{
    void Start()
    {
        Component fileSystem = new Directory("File system");
        Component diskC = new Directory("Disk C");

        // Files
        Component pngFile = new File("Image.png");
        Component docxFile = new File("Document.docx");

        // Add files to disk
        diskC.Add(pngFile);
        diskC.Add(docxFile);

        // Add disk C to file system
        fileSystem.Add(diskC);

        // Print all files
        fileSystem.Print();
        
        // Delete file from disk
        diskC.Remove(pngFile);

        // Add new folder
        Component docsFolder = new Directory("My documents");

        // Add files to new folder
        Component txtFile = new File("readme.txt");
        Component csFile = new File("Program.cs");

        docsFolder.Add(txtFile);
        docsFolder.Add(csFile);
        diskC.Add(docsFolder);

        // Print all files
        fileSystem.Print();
    }
}
