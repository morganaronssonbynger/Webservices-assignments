/**
 * WebServicePA5Locator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class WebServicePA5Locator extends org.apache.axis.client.Service implements org.tempuri.WebServicePA5 {

    public WebServicePA5Locator() {
    }


    public WebServicePA5Locator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public WebServicePA5Locator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for WebServicePA5Soap
    private java.lang.String WebServicePA5Soap_address = "http://localhost/PA5WS/WebServicePA5.asmx";

    public java.lang.String getWebServicePA5SoapAddress() {
        return WebServicePA5Soap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String WebServicePA5SoapWSDDServiceName = "WebServicePA5Soap";

    public java.lang.String getWebServicePA5SoapWSDDServiceName() {
        return WebServicePA5SoapWSDDServiceName;
    }

    public void setWebServicePA5SoapWSDDServiceName(java.lang.String name) {
        WebServicePA5SoapWSDDServiceName = name;
    }

    public org.tempuri.WebServicePA5Soap getWebServicePA5Soap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(WebServicePA5Soap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getWebServicePA5Soap(endpoint);
    }

    public org.tempuri.WebServicePA5Soap getWebServicePA5Soap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.WebServicePA5SoapStub _stub = new org.tempuri.WebServicePA5SoapStub(portAddress, this);
            _stub.setPortName(getWebServicePA5SoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setWebServicePA5SoapEndpointAddress(java.lang.String address) {
        WebServicePA5Soap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.WebServicePA5Soap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.WebServicePA5SoapStub _stub = new org.tempuri.WebServicePA5SoapStub(new java.net.URL(WebServicePA5Soap_address), this);
                _stub.setPortName(getWebServicePA5SoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("WebServicePA5Soap".equals(inputPortName)) {
            return getWebServicePA5Soap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "WebServicePA5");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "WebServicePA5Soap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("WebServicePA5Soap".equals(portName)) {
            setWebServicePA5SoapEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
