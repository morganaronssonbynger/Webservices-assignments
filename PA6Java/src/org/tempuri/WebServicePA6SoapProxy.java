package org.tempuri;

public class WebServicePA6SoapProxy implements org.tempuri.WebServicePA6Soap {
  private String _endpoint = null;
  private org.tempuri.WebServicePA6Soap webServicePA6Soap = null;
  
  public WebServicePA6SoapProxy() {
    _initWebServicePA6SoapProxy();
  }
  
  public WebServicePA6SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServicePA6SoapProxy();
  }
  
  private void _initWebServicePA6SoapProxy() {
    try {
      webServicePA6Soap = (new org.tempuri.WebServicePA6Locator()).getWebServicePA6Soap();
      if (webServicePA6Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServicePA6Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServicePA6Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServicePA6Soap != null)
      ((javax.xml.rpc.Stub)webServicePA6Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.WebServicePA6Soap getWebServicePA6Soap() {
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap;
  }
  
  public java.lang.String[][] getEmployeesWhoWhereSick2004() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getEmployeesWhoWhereSick2004();
  }
  
  public java.lang.String[][] getEmployeesWithMostAbscense() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getEmployeesWithMostAbscense();
  }
  
  public java.lang.String[][] getEmployeesAndRelatives() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getEmployeesAndRelatives();
  }
  
  public java.lang.String[][] getMetaDataFromEmployeeTable() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getMetaDataFromEmployeeTable();
  }
  
  public java.lang.String[][] getKeyConstraints() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getKeyConstraints();
  }
  
  public java.lang.String[][] getIndexes() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getIndexes();
  }
  
  public java.lang.String[][] getTableConstraints() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getTableConstraints();
  }
  
  public java.lang.String[][] getTablesMethodOne() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getTablesMethodOne();
  }
  
  public java.lang.String[][] getTablesMethodTwo() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getTablesMethodTwo();
  }
  
  public java.lang.String[][] getEmployeeColumnsOne() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getEmployeeColumnsOne();
  }
  
  public java.lang.String[][] getEmployeeColumnsTwo() throws java.rmi.RemoteException{
    if (webServicePA6Soap == null)
      _initWebServicePA6SoapProxy();
    return webServicePA6Soap.getEmployeeColumnsTwo();
  }
  
  
}