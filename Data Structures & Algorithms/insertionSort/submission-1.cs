// Definition for a pair
//public class Pair {
//     public int Key;
//     public string Value;
//
//   public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
//}

public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> result = new List<List<Pair>>();
        
        for(int i = 0; i < pairs.Count; i++) {
            Pair current = pairs[i];
            int anterior = i - 1;

            while(anterior >= 0 && pairs[anterior].Key > current.Key){
                pairs[anterior + 1] = pairs[anterior];
                anterior--;
            }

            pairs[anterior + 1] = current;

            result.Add(new List<Pair>(pairs));
        }

        return result;
    }
}
