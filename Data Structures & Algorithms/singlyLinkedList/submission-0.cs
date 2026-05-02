public class LinkedList {

    private Node head;

    class Node {
        public int val;
        public Node next;

        public Node(int val) {
            this.val = val;
            this.next = null;
        }
    }

    public LinkedList() {
        head = null;
    }

    public int Get(int index) {
        Node atual = head;
        int contador = 0;

        while(atual != null) {
            if(contador == index){
                return atual.val;
            }

            atual = atual.next;
            contador++;
        }
        return -1;
    }

    public void InsertHead(int val) {
        Node novo = new Node(val);

        novo.next = head;
        head = novo;
    }

    public void InsertTail(int val) {
        Node novo = new Node(val);

        if(head == null) {
            head = novo;
            return;
        }

        Node atual = head;

        while(atual.next != null){ 
            atual = atual.next;
        }

        atual.next = novo;
    }

    public bool Remove(int index) {
        if(head == null) {
            return false;
        }

        if(index == 0){
            head = head.next;
            return true;
        }

        Node atual = head;
        int contador = 0;

        while(atual != null && contador < index - 1){
            atual = atual.next;
            contador++;
        }

        if(atual == null || atual.next == null) {
            return false;
        }

        atual.next = atual.next.next;
        return true;
    }

    public List<int> GetValues() {
        List<int> valores = new List<int>();

        Node atual = head;

        while (atual != null)
        {
            valores.Add(atual.val);
            atual = atual.next;
        }

        return valores;
    }
}