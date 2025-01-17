﻿using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class btc7
    {
        static void Main(string[] args)
        {
            // Tạo một Từ điển <TKey, TValue>
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Thêm một số giá trị cặp khóa vào Từ điển
            dictionary.Add("apple", 5);
            dictionary.Add("banana", 3);
            dictionary.Add("orange", 7);
            dictionary.Add("grape", 2);

            // Kiểm tra xem một khóa có tồn tại trong Từ điển hay không
            string key = "apple";
            if (dictionary.ContainsKey(key))
            {
                Console.WriteLine($"The key '{key}' exists in the dictionary.");
            }
            else
            {
                Console.WriteLine($"The key '{key}' does not exist in the dictionary.");
            }

            // Truy xuất giá trị được liên kết với một khóa nhất định một cách an toàn
            key = "banana";
            if (dictionary.TryGetValue(key, out int value))
            {
                Console.WriteLine($"The value associated with the key '{key}' is {value}.");
            }
            else
            {
                Console.WriteLine($"The key '{key}' does not exist in the dictionary.");
            }

            // Lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
            Console.WriteLine("All key-value pairs in the dictionary:");
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}