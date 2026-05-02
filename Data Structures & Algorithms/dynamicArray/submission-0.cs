public class DynamicArray {
    private int[] arr;
    private int size; 
    private int capacity;
    
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.size = 0;
        this.arr = new int[capacity];
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if(size == capacity) 
        {
            Resize();
        }

        arr[size] = n;
        size++;
    }

    public int PopBack() {
        int valor = arr[size - 1];
        size--;

        return valor;
    }

    private void Resize() {
        capacity = capacity * 2;

        int[] novoArray = new int[capacity];

        for (int i = 0; i < size; i++)
        {
            novoArray[i] = arr[i];
        }

        arr = novoArray;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
