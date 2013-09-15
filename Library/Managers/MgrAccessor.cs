//
// mTouch-PDFReader library
// MgrAccessor.cs (Document bookmarks manager)
//
//  Author:
//       Alexander Matsibarov (macasun) <amatsibarov@gmail.com>
//
//  Copyright (c) 2012 Alexander Matsibarov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using mTouchPDFReader.Library.Interfaces;
using mTouchPDFReader.Library.Utils;

namespace mTouchPDFReader.Library.Managers
{
	public static class MgrAccessor
	{
		public static IDocumentNoteManager DocumentNoteMgr {
			get { return _DocumentNoteMgr ?? (_DocumentNoteMgr = RC.Get<IDocumentNoteManager>()); }
		}
		private static IDocumentNoteManager _DocumentNoteMgr; 

	
		public static IDocumentBookmarkManager DocumentBookmarkMgr {
			get { return _DocumentBookmarkMgr ?? (_DocumentBookmarkMgr = RC.Get<IDocumentBookmarkManager>()); }
		}
		private static IDocumentBookmarkManager _DocumentBookmarkMgr;

		public static IOptionsManager OptionsMgr {
			get { return _OptionsMgr ?? (_OptionsMgr = RC.Get<IOptionsManager>()); }
		}
		private static IOptionsManager _OptionsMgr;
	}
}

