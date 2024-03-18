package org.tempuri;

public class WebServicePA3SoapProxy implements org.tempuri.WebServicePA3Soap {
  private String _endpoint = null;
  private org.tempuri.WebServicePA3Soap webServicePA3Soap = null;
  
  public WebServicePA3SoapProxy() {
    _initWebServicePA3SoapProxy();
  }
  
  public WebServicePA3SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServicePA3SoapProxy();
  }
  
  private void _initWebServicePA3SoapProxy() {
    try {
      webServicePA3Soap = (new org.tempuri.WebServicePA3Locator()).getWebServicePA3Soap();
      if (webServicePA3Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServicePA3Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServicePA3Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServicePA3Soap != null)
      ((javax.xml.rpc.Stub)webServicePA3Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.WebServicePA3Soap getWebServicePA3Soap() {
    if (webServicePA3Soap == null)
      _initWebServicePA3SoapProxy();
    return webServicePA3Soap;
  }
  
  public java.lang.String getFile(java.lang.String fileName) throws java.rmi.RemoteException{
    if (webServicePA3Soap == null)
      _initWebServicePA3SoapProxy();
    return webServicePA3Soap.getFile(fileName);
  }
  
  
}