/*
 * Project: Spr2020_TryCatchBlock
 * Filename: Program.cs
 * Author: R. Snell
 * Date: Feb. 13, 2020
 * Purpose: To introduce the optimal finally clause of the Try/Catch block
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Spr2020_TryCatchFinallyBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Case 1: No exception occur in the called method
            Console.WriteLine("Calling DoesNotThrowException() methos.");
            DoesNotThrowException();

            // Case 2: Exception occurs and is caught in the called method
            Console.WriteLine("\nCalling ThrowExceptionCatch() methos.");
            ThrowExceptionWithCatch();

            // Case 3: Exception occurs, but is not caught in called method
            // because there is no catch block
            Console.WriteLine("\nCalling ThrowExceptionWithouthCatch() method.");
            // Call the last method
            try
            {
                ThrowExceptionWithoutCatch();
            }   
            catch
            {
                Console.WriteLine("Caught exception from " +
                    "ThrowExceptionWithoutCatch() in Main(). ");
            }

            // Case 4: Exception occurs and is caught in called method
            // and then rethrown to calling method.
            Console.WriteLine("\n Calling ThrowExceptionCatchMethod(). ");
            try
            {
                ThrowExceptionCatchRethrow();
            }
            catch
            {
                Console.WriteLine("Caught exception from " +
                    "ThrowExceptionCatchRethrow(). ");
            }
        }   // end Main()

        // No exception handler
        static void DoesNotThrowException()
        {
            // The try/catch block does not throw any exceptions
            try
            {
                Console.WriteLine("In DoesNotThrowException(). ");
            }
            catch 
            { 
                Console.WriteLine("This catch never executes. "); 
            }
            finally // The optimal clause of a try/catch block
            {
                Console.WriteLine("Finally executed in DoesNotThrowException(). ");
            }   // end try/catch/finally block

            Console.WriteLine("End of DoesNotThrowException(). ");
        }   // end DoesNotThrowException()
        
        // Throws exception and handles it locally
        static void ThrowExceptionWithCatch()
        {
            try
            {
                Console.WriteLine("In ThrowExceptionWithCatch(). ");
                throw new Exception("Exception in ThrowExceptionWithCatch(). ");
            }
            catch ( Exception exParameter)
            {
                Console.WriteLine($"Message: { exParameter.Message}");
            }
            finally
            {
                Console.WriteLine("finally executed in throwExceptionWithCatch(). ");
            }   // end try/catch/finally block

            Console.WriteLine("End of ThrowExceptionWithCatch(). ");
        }   // end ThrowExceptionWithCatch
        // Throws exception and handles it locally
        static void ThrowExceptionWithoutCatch()
        {
            try
            {
                Console.WriteLine("In ThrowExceptionWithCatch(). ");
                throw new Exception("Exception in ThrowExceptionWithoutCatch(). ");
            }
            catch (Exception exParameter)
            {
                Console.WriteLine($"Message: { exParameter.Message}");
            }
            finally
            {
                Console.WriteLine("finally executed in throwExceptionWithoutCatch(). ");
            }   // end try/catch/finally block

            // This code is never reached
            Console.WriteLine("End of ThrowExceptionWithoutCatch(). ");
        }   // end ThrowExceptionWithoutCatch

        // Throws exception and handles it locally
        static void ThrowExceptionCatchRethrow()
            {
                try
                {
                    Console.WriteLine("In ThrowExceptionCatchRethrow(). ");
                    throw new Exception("Exception in ThrowExceptionCatchRethrow(). ");
                }
                catch (Exception exParameter)
                {
                    Console.WriteLine($"Message: { exParameter.Message}");
                }
                finally
                {
                    Console.WriteLine("finally executed in ThrowExceptionCatchRethrow(). ");
                }   // end try/catch/finally block
            // This code is never reached
            Console.WriteLine("End of ThrowExceptionCatchRethrow(). ");
            }   // end ThrowExceptionCatchRethrow
     
    }   // end class
}   // end namespace
