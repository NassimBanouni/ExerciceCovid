/***********************************************************************
 * Module:  Douteux.cs
 * Author:  ayman
 * Purpose: Definition of the Class Douteux
 ***********************************************************************/

using System;

public class Douteux : Citoyen
{
   public void Susper()
   {
      // TODO: implement
   }

   public System.Collections.ArrayList test;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetTest()
   {
      if (test == null)
         test = new System.Collections.ArrayList();
      return test;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetTest(System.Collections.ArrayList newTest)
   {
      RemoveAllTest();
      foreach (Test oTest in newTest)
         AddTest(oTest);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddTest(Test newTest)
   {
      if (newTest == null)
         return;
      if (this.test == null)
         this.test = new System.Collections.ArrayList();
      if (!this.test.Contains(newTest))
         this.test.Add(newTest);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveTest(Test oldTest)
   {
      if (oldTest == null)
         return;
      if (this.test != null)
         if (this.test.Contains(oldTest))
            this.test.Remove(oldTest);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllTest()
   {
      if (test != null)
         test.Clear();
   }

   private String Couleur = Rouge;

}