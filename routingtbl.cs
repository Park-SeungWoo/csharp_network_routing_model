using System.Collections.Generic;
namespace networknode
{
    class rtable
    {
        private static Dictionary<int, char> node1R = new Dictionary<int, char> {
                {1, '0'},
                {2, '2'},
                {3, '2'},
                {4, '2'},
                {5, '2'},
                {6, '2'},
                {7, '2'}
        };

        private static Dictionary<int, char> node2R = new Dictionary<int, char> {
                {1, '1'},
                {2, '0'},
                {3, '3'},
                {4, '4'},
                {5, '4'},
                {6, '4'},
                {7, '4'}
        };

        private static Dictionary<int, char> node3R = new Dictionary<int, char> {
                {1, '2'},
                {2, '2'},
                {3, '0'},
                {4, '4'},
                {5, '4'},
                {6, '4'},
                {7, '4'}
        };

        private static Dictionary<int, char> node4R = new Dictionary<int, char> {
                {1, '2'},
                {2, '2'},
                {3, '3'},
                {4, '0'},
                {5, '6'},
                {6, '6'},
                {7, '6'}
        };

        private static Dictionary<int, char> node5R = new Dictionary<int, char> {
                {1, '6'},
                {2, '6'},
                {3, '6'},
                {4, '6'},
                {5, '0'},
                {6, '6'},
                {7, '6'}
        };

        private static Dictionary<int, char> node6R = new Dictionary<int, char> {
                {1, '4'},
                {2, '4'},
                {3, '4'},
                {4, '4'},
                {5, '5'},
                {6, '0'},
                {7, '7'}
        };

        private static Dictionary<int, char> node7R = new Dictionary<int, char> {
                {1, '6'},
                {2, '6'},
                {3, '6'},
                {4, '6'},
                {5, '6'},
                {6, '6'},
                {7, '0'}
        };
        private static Dictionary<int, char> node0R = new Dictionary<int, char> {
                {1, 'n'},
                {2, 'n'},
                {3, 'n'},
                {4, 'n'},
                {5, 'n'},
                {6, 'n'},
                {7, 'n'}
        };
        public static Dictionary<int, char> getrtable(int i)
        {
            switch (i)
            {
                case 1:
                    return node1R;
                case 2:
                    return node2R;
                case 3:
                    return node3R;
                case 4:
                    return node4R;
                case 5:
                    return node5R;
                case 6:
                    return node6R;
                case 7:
                    return node7R;
                default:
                    return node0R;
            }
        }
    }
}