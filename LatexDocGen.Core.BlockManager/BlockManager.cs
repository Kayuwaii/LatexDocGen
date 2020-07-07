using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core.BlockManager
{
    public class BlockManager
    {
        private Dictionary<string, Block> BlockRepository;
        public int TotalBlocks { get; private set; }

        public delegate void LoadingStartedeHandler(int total);

        public event LoadingStartedeHandler OnLoadingStarted;

        public delegate Task SingleBlockLoadedHandler(string name);

        public event SingleBlockLoadedHandler OnSingleBlockLoaded;

        public BlockManager()
        {
            BlockRepository = new Dictionary<string, Block>();
            TotalBlocks = 0;
        }

        public void LoadBlocks()
        {
            string zipPath = @".\Data\Blocks.lbi";

            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                TotalBlocks = archive.Entries.Count(x => x.FullName.EndsWith("/") && x.FullName.Split('/').Length == 2);
                OnLoadingStarted(TotalBlocks);
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    OnSingleBlockLoaded(entry.Name); //TODO: Change to add block to list, and notify.
                }
            }
        }
    }
}