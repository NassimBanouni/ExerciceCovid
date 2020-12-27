/***********************************************************************
 * Module:  Spetaliser.cs
 * Author:  nassim
 * Purpose: Definition of the Class Spetaliser
 ***********************************************************************/

using System;

public class Spetaliser : NegatveTest
{
   public void AffDecision()
   {
        Console.WriteLine("En raison de la deterioration de votre senté, vous devez rester en hopitale");
   }

   private String EtatStenter = Endommager;

}