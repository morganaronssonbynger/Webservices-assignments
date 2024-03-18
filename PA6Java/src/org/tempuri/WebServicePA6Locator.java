/**
 * WebServicePA6Locator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class WebServicePA6Locator extends org.apache.axis.client.Service implements org.tempuri.WebServicePA6 {

    public WebServicePA6Locator() {
    }


    public WebServicePA6Locator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public WebServicePA6Locator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for WebServicePA6Soap
    private java.lang.String WebServicePA6Soap_address = "http://localhost/PA6WS/WebServicePA6.asmx";

    public java.lang.String getWebServicePA6SoapAddress() {
        return WebServicePA6Soap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String WebServicePA6SoapWSDDServiceName = "WebServicePA6Soap";

    public java.lang.String getWebServicePA6SoapWSDDServiceName() {
        return WebServicePA6SoapWSDDServiceName;
    }

    public void setWebServicePA6SoapWSDDServiceName(java.lang.String name) {
        WebServicePA6SoapWSDDServiceName = name;
    }

    public org.tempuri.WebServicePA6Soap getWebServicePA6Soap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(WebServicePA6Soap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getWebServicePA6Soap(endpoint);
    }

    public org.tempuri.WebServicePA6Soap getWebServicePA6Soap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.WebServicePA6SoapStub _stub = new org.tempuri.WebServicePA6SoapStub(portAddress, this);
            _stub.setPortName(getWebServicePA6SoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setWebServicePA6SoapEndpointAddress(java.lang.String address) {
        WebServicePA6Soap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.WebServicePA6Soap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.WebServicePA6SoapStub _stub = new org.tempuri.WebServicePA6SoapStub(new java.net.URL(WebServicePA6Soap_address), this);
                _stub.setPortName(getWebServicePA6SoapWSDDServiceName());
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
        if ("WebServicePA6Soap".equals(inputPortName)) {
            return getWebServicePA6Soap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "WebServicePA6");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "WebServicePA6Soap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("WebServicePA6Soap".equals(portName)) {
            setWebServicePA6SoapEndpointAddress(address);
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
