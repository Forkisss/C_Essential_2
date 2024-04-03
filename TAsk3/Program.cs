using TAsk3;

Invoice invoice = new Invoice(1, "Customer Name", "Provider Name");
invoice.SetOrderDetails("Laptop", 2); 

invoice.CalculatePayment(includeVAT: true); 
invoice.CalculatePayment(includeVAT: false); 