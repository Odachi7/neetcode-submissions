public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int leftMax = height[left];
        int rightMax = height[right];
        int total = 0;

        while (left < right) {
            if (leftMax < rightMax) {
                left++;
                if (height[left] > leftMax) {
                    leftMax = height[left];
                } else {
                    total += leftMax - height[left];
                }
            } else {
                right--;
                if (height[right] > rightMax) {
                    rightMax = height[right];
                } else {
                    total += rightMax - height[right];
                }
            }
        }

        return total;
    }
}