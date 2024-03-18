package org.tempuri;

public class WebServicePA5SoapProxy implements org.tempuri.WebServicePA5Soap {
  private String _endpoint = null;
  private org.tempuri.WebServicePA5Soap webServicePA5Soap = null;
  
  public WebServicePA5SoapProxy() {
    _initWebServicePA5SoapProxy();
  }
  
  public WebServicePA5SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServicePA5SoapProxy();
  }
  
  private void _initWebServicePA5SoapProxy() {
    try {
      webServicePA5Soap = (new org.tempuri.WebServicePA5Locator()).getWebServicePA5Soap();
      if (webServicePA5Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServicePA5Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServicePA5Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServicePA5Soap != null)
      ((javax.xml.rpc.Stub)webServicePA5Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.WebServicePA5Soap getWebServicePA5Soap() {
    if (webServicePA5Soap == null)
      _initWebServicePA5SoapProxy();
    return webServicePA5Soap;
  }
  
  public org.tempuri.CRONUS_Sverige_AB_Employee[] getEmployees() throws java.rmi.RemoteException{
    if (webServicePA5Soap == null)
      _initWebServicePA5SoapProxy();
    return webServicePA5Soap.getEmployees();
  }
  
  public org.tempuri.CRONUS_Sverige_AB_Employee getEmployee(java.lang.String no_) throws java.rmi.RemoteException{
    if (webServicePA5Soap == null)
      _initWebServicePA5SoapProxy();
    return webServicePA5Soap.getEmployee(no_);
  }
  
  public void createEmployee(java.lang.String firstName, java.lang.String lastName, java.lang.String address, java.lang.String jobTitle) throws java.rmi.RemoteException{
    if (webServicePA5Soap == null)
      _initWebServicePA5SoapProxy();
    webServicePA5Soap.createEmployee(firstName, lastName, address, jobTitle);
  }
  
  public void updateEmployee(java.lang.String no_, java.lang.String firstName, java.lang.String lastName, java.lang.String address, java.lang.String jobTitle) throws java.rmi.RemoteException{
    if (webServicePA5Soap == null)
      _initWebServicePA5SoapProxy();
    webServicePA5Soap.updateEmployee(no_, firstName, lastName, address, jobTitle);
  }
  
  public void removeEmployee(java.lang.String no_) throws java.rmi.RemoteException{
    if (webServicePA5Soap == null)
      _initWebServicePA5SoapProxy();
    webServicePA5Soap.removeEmployee(no_);
  }
  
  
}