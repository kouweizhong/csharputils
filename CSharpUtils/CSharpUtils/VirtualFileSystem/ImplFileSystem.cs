﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpUtils.VirtualFileSystem
{
	public class ImplFileSystem : FileSystem
	{
		internal override void ImplSetFileTime(string Path, FileSystemEntry.FileTime FileTime)
		{
			throw new NotImplementedException();
		}

		internal override FileSystemEntry ImplGetFileInfo(string Path)
		{
			throw new NotImplementedException();
		}

		internal override void ImplDeleteFile(string Path)
		{
			throw new NotImplementedException();
		}

		internal override void ImplDeleteDirectory(string Path)
		{
			throw new NotImplementedException();
		}

		internal override void ImplMoveFile(string ExistingFileName, string NewFileName, bool ReplaceExisiting)
		{
			throw new NotImplementedException();
		}

		internal override void ImplFindFiles(string Path, LinkedList<FileSystemEntry> List)
		{
			throw new NotImplementedException();
		}

		internal override FileSystemFileStream ImplOpenFile(string FileName, System.IO.FileMode FileMode)
		{
			throw new NotImplementedException();
		}

		internal override void ImplWriteFile(FileSystemFileStream FileStream, byte[] Buffer, int Offset, int Count)
		{
			throw new NotImplementedException();
		}

		internal override int ImplReadFile(FileSystemFileStream FileStream, byte[] Buffer, int Offset, int Count)
		{
			throw new NotImplementedException();
		}

		internal override void ImplCloseFile(FileSystemFileStream FileStream)
		{
			//throw new NotImplementedException();
		}

		internal override void ImplCreateDirectory(string Path, int Mode = 0777)
		{
			throw new NotImplementedException();
		}
	}
}
