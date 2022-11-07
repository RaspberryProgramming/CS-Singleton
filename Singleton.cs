using System;

public class Runner {
    public static void Main() {

        // Create first instance
        Singleton st = Singleton.Instance;

        st.value = "Hello";

        Console.WriteLine(st.value);

        // Second Singleton
        Singleton st2 = Singleton.Instance;

        st2.value = "World";

        // Third Singleton
        Singleton st3 = Singleton.Instance;

        st.value = "Hello " + st.value + ". This is a singleton";

        // Display st3 value
        Console.WriteLine(st3.value);

        // Demonstrate that st has a count of 3 instances
        Console.WriteLine($"We've coped {st.count} instances so far...");

    }


}

public class Singleton {
    private static Singleton instance = null;

    public string value; // Value that is publicly accessible
    private static short _count = 0; // Used to count within the singleton
    
    private Singleton() {
    }

    static Singleton() {
    }

    // Used to interact with counter
    public short count {
        get {
            return _count;
        }
        private set {
            _count = value;
        }
    }

    public static Singleton Instance {
        get{
            if(instance == null) {
                // Since no instance exists yet, create new one
                instance = new Singleton();
            }

            instance.count++; // Increment counter

            return instance;
        }
    }
}